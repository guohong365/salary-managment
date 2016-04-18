using System;
using System.Collections.Generic;
using System.Data;
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

            public static void SetMonthScheduleState(DataTable annualAssignment, int month, int state)
            {
                annualAssignment.Rows.Cast<DataRow>().ToList().Find(item => (Convert.ToInt32(item[COL_MONTH]) == month))
                    [COL_STATE] = state;
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

            [Flags]
            enum NodeTypeFlags
            {
                UNKNOWN=              0x00000000,
                EMPLOYEE=             0x00000001,  //员工节点 
                POSITSION=             0x10000000,  //岗位节点
                //HAS_EMPLOYEE =0x00000001, //岗位节点，下属有员工
                //NO_EMPLOYEE=4, //岗位节点，下属无员工
                HAS_EMPLOYEE_BY_CHILD=0x00000002, //岗位节点，直接下属无员工，但下属岗位有员工
                HAS_VALUE=            0x00000004 //岗位节点，占比为0
            }

            /// <summary>
            /// 检查所有自身及子节点类型
            /// </summary>
            /// <param name="node">待检查节点</param>
            /// <returns>输入节点的类型</returns>
            static NodeTypeFlags passthroughNodes(TreeListNode node)
            {
                NodeTypeFlags flags = NodeTypeFlags.UNKNOWN;

                if (!isPositionNode(node))
                {
                    flags |= NodeTypeFlags.EMPLOYEE;
                      node.Tag = flags;
                    return flags;
                }
                flags |= NodeTypeFlags.POSITSION;
                if (!node.HasChildren || Convert.ToDecimal(node.GetValue(COL_WEIGHT)) <=0)
                {
                    node.Tag = flags;
                    return flags;
                }
                flags |= NodeTypeFlags.HAS_VALUE;
                
                foreach (TreeListNode child in node.Nodes)
                {
                    if (!isPositionNode(child))
                    {
                        flags |= NodeTypeFlags.EMPLOYEE;
                        child.Tag = NodeTypeFlags.EMPLOYEE;
                    }
                    else
                    {
                        flags |= passthroughNodes(child);
                    }
                }
                node.Tag = flags;
                return flags;
            }

            public static void AssignNode(TreeListNodes nodes, decimal total, int month)
            {
                List<TreeListNode> reassignChildren= new List<TreeListNode>();
                List<TreeListNode> employee=new List<TreeListNode>();
                foreach (TreeListNode node in nodes)
                {
                    NodeTypeFlags type =  (NodeTypeFlags) node.Tag;
                    if (!type.HasFlag(NodeTypeFlags.EMPLOYEE))
                    {
                        continue;
                    }

                    if (type == NodeTypeFlags.EMPLOYEE) //本级员工节点
                    {
                        employee.Add(node);
                        continue;
                    }

                    reassignChildren.Add(node); //下级需再分配岗位节点
                }

                //本级员工节点直接平分
                employee.ForEach(item =>
                {
                    item[COL_TARGET] = total/employee.Count;
                    //如果该节点为新增节点，生成任务主键
                    if (string.IsNullOrEmpty(Convert.ToString(item[COL_PERF_ID])))
                    {
                        item[COL_PERF_ID] = Guid.NewGuid().ToString();
                    }
                } );

                //下级节点按比例再分配
                
                //计算下级节点再分配占比归一因子
                decimal allRate = reassignChildren.Sum(item => Convert.ToDecimal(item.GetValue(COL_WEIGHT)));
                
                foreach (TreeListNode child in reassignChildren)
                {
                    //计算当前子结点动态占比
                    decimal rate = Convert.ToDecimal(child.GetValue(COL_WEIGHT))/allRate;
                    decimal nextTotal = Math.Floor(total * rate*100+(decimal) 0.5)/100;
                    //设置子节点任务额度
                    child.SetValue(COL_TARGET, nextTotal);
                    //再次向下分配
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

            public static void GenerateMonthAssignmentByEmployeeTee(TreeList treeList, decimal total)
            {
                treeList.BeginUpdate();
                assignNodeByEmployeeTree(treeList.Nodes, total);
                treeList.EndUpdate();
            }

            private static void assignNodeByEmployeeTree(TreeListNodes nodes, decimal total)
            {
                Dictionary<string, List<TreeListNode>> samePosition=new Dictionary<string, List<TreeListNode>>();
                foreach (TreeListNode node in nodes)
                {
                    string positionId = node.GetValue("POSITION_ID").ToString();
                    if (!samePosition.ContainsKey(positionId))
                    {
                        samePosition.Add(positionId, new List<TreeListNode>());
                    }
                    samePosition[positionId].Add(node) ;
                }
                foreach (KeyValuePair<string, List<TreeListNode>> pair in samePosition)
                {
                    int employeeCount= pair.Value.Count;
                    decimal target = Math.Floor(total * Convert.ToDecimal(pair.Value[0].GetValue("POSITION_WEIGHT"))*100+ (decimal) 0.5)/10000/employeeCount;
                    foreach (TreeListNode employeeNode in pair.Value)
                    {
                        employeeNode.SetValue(COL_TARGET, target);
                        assignNodeByEmployeeTree(employeeNode.Nodes, target);
                    }
                }
            }
        }
    }
}