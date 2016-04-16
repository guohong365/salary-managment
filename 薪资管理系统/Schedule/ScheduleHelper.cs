using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace SalarySystem.Schedule
{
    internal class ScheduleHelper
    {
        public class Annual
        {
            public const string COL_DEF_ID = "DEF_ID";
            public const string COL_TASK_ID = "ID";
            public const string COL_TASK_NAME = "NAME";
            public const string COL_TASK_DESC = "DESCRIPTION";
            public const string COL_YEAR = "YEAR";
            public const string COL_MONTH = "MONTH";
            public const string COL_TARGET = "TARGET";
            public const string COL_CREATE_TIME = "CREATE_TIME";
            public const string COL_VERSION_ID = "VERSION_ID";
            public const string COL_CREATOR = "CREATOR";
            public const string COL_STATE = "STATE";
            public const string COL_DEF_NAME = "DEF_NAME";
            public const string COL_RATE = "RATE";


            public const string SUMMARY_ID = "summary";

            public static void AddAnnualSumarry(DataTable dataTable)
            {
                DataRow row = dataTable.NewRow();
                row[COL_DEF_ID] = SUMMARY_ID;
                row[COL_TASK_ID] = "";
                row[COL_TASK_NAME] = "";
                row[COL_TASK_DESC] = "";
                row[COL_YEAR] = 0;
                row[COL_MONTH] = 100;
                row[COL_TARGET] = 0;
                row[COL_CREATE_TIME] = DateTime.Now;
                row[COL_VERSION_ID] = "";
                row[COL_STATE] = 0;
                row[COL_CREATOR] = "";
                row[COL_DEF_NAME] = "";
                row[COL_RATE] = 0;
                dataTable.Rows.Add(row);
                dataTable.AcceptChanges();
                RecalcAnnaualSumarry(dataTable);
            }

            public static int GetMonthScheduleState(DataTable dataTable, int month)
            {
                return
                    Convert.ToInt32(
                        dataTable.Rows.Cast<DataRow>()
                            .ToList()
                            .Find(item => (Convert.ToInt32(item[COL_MONTH]) == month))[COL_STATE]);
            }

            public static void RecalcAnnaualSumarry(DataTable dataTable)
            {
                DataRow[] dataRows = dataTable.Select(string.Format("[{0}]='{1}'",COL_DEF_ID, SUMMARY_ID));
                if (dataRows.Length == 0)
                {
                    AddAnnualSumarry(dataTable);
                    return;
                }
                DataRow summaryRow = dataRows[0];
                summaryRow[COL_TARGET] =
                    dataTable.Rows.Cast<DataRow>()
                        .ToList()
                        .Sum(item => Equals(item[COL_DEF_ID], SUMMARY_ID) ? 0 : (decimal) item[COL_TARGET]);
                summaryRow[COL_RATE] =
                    dataTable.Rows.Cast<DataRow>()
                        .ToList()
                        .Sum(item => Equals(item[COL_DEF_ID], SUMMARY_ID) ? 0 : (decimal) item[COL_RATE]);
            }

            public static decimal GetMonthAmont(DataTable dataTable, int month)
            {
                return
                    Convert.ToDecimal(
                        dataTable.Rows.Cast<DataRow>()
                            .ToList()
                            .Find(item => (Convert.ToInt32(item[COL_MONTH]) == month))[COL_TARGET]);
            }
        }

        public class Monthly
        {
            public const string COL_PERF_ID = "PERF_ID";
            public const string COL_WEIGHT = "WEIGHT";
            public const string COL_TARGET = "TARGET";
            public const string COL_EMPLOYEE_ID = "EMPLOYEE_ID";


            static bool isPositionNode(TreeListNode node)
            {
                object val = node.GetValue(COL_EMPLOYEE_ID);
                return (val == null || DBNull.Value.Equals(val) || string.IsNullOrEmpty(Convert.ToString(val)));
            }

            enum NodeState
            {
                EMP,
                POS_NO_EMP,
                POS_HAS_EMP,
                POS_HAS_EMP_BY_CHILD,
                POS_NO_VALUE
            }

            static bool passthroughNodes(TreeListNode node)
            {
                node.Tag = null;

                if (!isPositionNode(node))
                {
                    node.Tag = NodeState.EMP;
                    return false;
                }
                if (!node.HasChildren || Convert.ToDecimal(node.GetValue(COL_WEIGHT)) <=0)
                {
                    node.Tag = NodeState.POS_NO_EMP;
                    return false;
                }
                foreach (TreeListNode child in node.Nodes)
                {
                    if (!isPositionNode(child))
                    {
                        node.Tag = NodeState.POS_HAS_EMP;
                        child.Tag = NodeState.EMP;
                    }
                    else
                    {
                        bool ret = passthroughNodes(child);
                        if (node.Tag != null) continue;
                        node.Tag = ret ? NodeState.POS_HAS_EMP_BY_CHILD : NodeState.POS_NO_EMP;
                    }
                }
                return (NodeState)node.Tag== NodeState.POS_HAS_EMP || (NodeState)node.Tag== NodeState.POS_HAS_EMP_BY_CHILD ;
            }

            public static void AssignNode(TreeListNodes nodes, decimal total, int month)
            {
                List<TreeListNode> reassignChildren= new List<TreeListNode>();
                List<TreeListNode> employee=new List<TreeListNode>();
                foreach (TreeListNode node in nodes)
                {
                    NodeState type = (NodeState) node.Tag;
                    switch (type)
                    {
                        case NodeState.POS_NO_EMP:
                            continue;
                        case NodeState.EMP: //本级员工节点
                            employee.Add(node);
                            break;
                        case NodeState.POS_HAS_EMP: //下级岗位节点
                        case NodeState.POS_HAS_EMP_BY_CHILD:
                            reassignChildren.Add(node);
                            break;
                    }
                }
                //本级员工节点直接平分
                employee.ForEach(item =>
                {
                    item[COL_TARGET] = total/employee.Count;
                    if(string.IsNullOrEmpty(Convert.ToString(item[COL_PERF_ID])))
                        item[COL_PERF_ID] = Guid.NewGuid().ToString();
                } );

                //下级节点按比例再分配
                decimal allRate = reassignChildren.Sum(item => Convert.ToDecimal(item.GetValue(COL_WEIGHT)));
                foreach (TreeListNode child in reassignChildren)
                {
                    decimal rate = Convert.ToDecimal(child.GetValue(COL_WEIGHT));
                    decimal nextTotal = total * rate/allRate;
                    child.SetValue(COL_TARGET, nextTotal);
                    AssignNode(child.Nodes, nextTotal, month);
                }
            }
            public static void GenerateMonthAssignment(TreeList treeList, decimal total, int month)
            {
                treeList.Nodes.Cast<TreeListNode>().ToList().ForEach(node=>passthroughNodes(node));
                treeList.BeginUpdate();
                AssignNode(treeList.Nodes, total, month);
                treeList.EndUpdate();
            }
        }
    }
}