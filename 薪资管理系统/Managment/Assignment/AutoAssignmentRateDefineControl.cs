using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using SalarySystem.Data;
using UC.Platform.Data;
using CellValueChangedEventArgs = DevExpress.XtraTreeList.CellValueChangedEventArgs;

namespace SalarySystem.Managment.Assignment
{
    public partial class AutoAssignmentRateDefineControl : BaseEditableControl
    {
        private const string _COL_USED = "USED";

        private const string _COL_WEIGHT = "WEIGHT";
        private const string _COL_ID = "ID";

        protected readonly Color[] Colors =
        {
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Salmon,
            Color.Teal,
            Color.RoyalBlue
        };

        private readonly Dictionary<string, DataSetSalary.v_team_assignment_detailDataTable> _details =
            new Dictionary<string, DataSetSalary.v_team_assignment_detailDataTable>();

        private bool _preventValueChangedEvent;

        public AutoAssignmentRateDefineControl()
        {
            InitializeComponent();
        }

        protected override void onControlLoad()
        {
            base.onControlLoad();

            gridControlAssignmentDefine.DataSource = new DataView(DataHolder.AssignmentDefine)
            {
                RowFilter = string.Format("[ENABLED]=true AND [TYPE]='{0}'", GlobalSettings.TYPE_ASSIGNMENT_AUTO_ASSIGN)
            };
            _details.Values.ToList().ForEach(item => item.RowChanged += onRowChanged);
            //手工触发，装载TreeList数据
            focusedAssignmentDefinChanged(gridViewAssignmentDefine, new FocusedRowChangedEventArgs(-1, 0));
            repositoryItemLookUpEdit1.DataSource = DataHolder.Position;
            treeList1.CustomDrawNodeCell += GridViewHelper.CustomDrawNodeCell;
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            _details.Values.ToList().ForEach(item => item.RowChanged += onRowChanged);
            treeList1.ExpandAll();
        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _details.Values.ToList().ForEach(item => item.RowChanged -= onRowChanged);
        }

        private static void saveOneAssignmentDefine(DataSetSalary.v_team_assignment_detailDataTable dataTable, string defineId)
        {
            var positionAssignments=new DataSetSalary.t_position_assignmentsDataTable();
            DBHandlerEx.FillOnce(positionAssignments, string.Format("select * from t_position_assignments where ASSIGNMENT_ID='{0}'", defineId));
            foreach (var row in dataTable)
            {
                var dataRow = positionAssignments.FindByASSIGNMENT_IDPOSITION_ID(defineId, row.ID);
                if (dataRow != null)
                {
                    dataRow.WEIGHT = 100;
                    dataRow.ENABLED = row.USED;
                    dataRow.VALUE = row.WEIGHT;
                }
                else
                {
                    dataRow = positionAssignments.Newt_position_assignmentsRow();
                    dataRow.ASSIGNMENT_ID = row.DEFINE_ID;
                    dataRow.POSITION_ID = row.ID;
                    dataRow.WEIGHT = 100;
                    dataRow.VERSION_ID = row.VERSION_ID;
                    dataRow.ENABLED = row.USED;
                    dataRow.VALUE = row.WEIGHT;
                    positionAssignments.Addt_position_assignmentsRow(dataRow);
                }
            }
            if (DBHandlerEx.UpdateOnce(positionAssignments.GetChanges()) > 0)
            {
                dataTable.AcceptChanges();
            }
        }

        protected override void onSave()
        {
            base.onSave();
            _details.ToList().ForEach(item=>saveOneAssignmentDefine(item.Value, item.Key));
        }

        protected override void onRevert()
        {
            base.onRevert();
            _details.Values.ToList().ForEach(item => item.RejectChanges());
        }

        private static void checkChildren(TreeListNode thisNode, bool used)
        {
            if (!thisNode.HasChildren) return;
            decimal val = 100;
            decimal last = 100;
            if (used)
            {
                val = (decimal) ((int) ((100.0/thisNode.Nodes.Count)*100))/100;
                last = 100 - val*thisNode.Nodes.Count + val;
            }
            TreeListNode node = thisNode.FirstNode;
            while (node != null)
            {
                node.SetValue(_COL_WEIGHT, used ? (node.NextNode == null ? last : val) : 0);
                node.SetValue(_COL_USED, used);
                checkChildren(node, used);
                node = node.NextNode;
            }
        }

        private static void checkParent(TreeListNode thisNode)
        {
            while (true)
            {
                TreeListNode parentNode = thisNode.ParentNode;
                if (parentNode == null) return;

                //处理自身值的问题
                if ((bool) parentNode.GetValue(_COL_USED)) //本身就是选中的
                {
                    return;
                    //if (used) return; //啥也不做

                    ////如果是反选
                    ////查找其他兄弟是否有选中的，如有，返回。
                    //if (parentNode.Nodes.Cast<TreeListNode>().Any(brother => brother != thisNode && (bool) brother.GetValue(_COL_USED)))
                    //{
                    //    return;
                    //}
                    //parentNode.SetValue(_COL_WEIGHT, 0);
                    //parentNode.SetValue(_COL_USED, false);
                }
                
                parentNode.SetValue(_COL_USED, true);
                recalcWeight(parentNode);
                thisNode = parentNode;
            }
        }

        private void loadAssignmentDetail(string defineId)
        {
            string sql = string.Format("select * from v_team_assignment_detail where DEFINE_ID='{0}'", defineId);
            var dataTable = new DataSetSalary.v_team_assignment_detailDataTable();
            DBHandlerEx.FillOnce(dataTable, sql);
            _details.Add(defineId, dataTable);
        }

        private void focusedAssignmentDefinChanged(object sender, FocusedRowChangedEventArgs e)
        {
            DataRow row = gridViewAssignmentDefine.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                string defineId = (string) row[_COL_ID];
                if (!_details.ContainsKey(defineId))
                {
                    loadAssignmentDetail(defineId);
                }
                treeList1.DataSource = _details[row[_COL_ID].ToString()];
                treeList1.ExpandAll();
            }
            else
            {
                treeList1.DataSource = null;
            }
        }

        private void customDrawRowFooterCell(object sender, CustomDrawRowFooterCellEventArgs e)
        {
            if (e.Text == string.Empty) return;

            if (e.Column.FieldName == _COL_WEIGHT && e.Node.ParentNode != null)
            {
                var val = (decimal) treeList1.GetGroupSummaryValue(e.Column, e.Node.ParentNode.Nodes);
                if (val != 100)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        private static void recalcWeight(TreeListNode node)
        {
            TreeListNodes brothers = node.ParentNode != null ? node.ParentNode.Nodes : node.RootNode.Nodes;

            decimal sum = 0;
            decimal newValue = 0;

            //int count = brothers.Cast<TreeListNode>().Count(item => (bool) item.GetValue(_COL_USED));
            

            if (brothers.Count > 2)
            {
                sum +=
                    (from TreeListNode brother in brothers
                        where brother != node
                        select (decimal) brother.GetValue(_COL_WEIGHT)).Sum();
                if (sum < 100)
                {
                    newValue = 100 - sum;
                }
            }
            else
            {
                newValue = 100;
            }
            node.SetValue(_COL_WEIGHT, newValue);
        }

        private void cellValueChange(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName != _COL_USED && _preventValueChangedEvent) return;
            _preventValueChangedEvent = true;
            if ((bool) e.Value)
            {
                recalcWeight(e.Node);
                checkParent(e.Node);
                checkChildren(e.Node,true);
            }
            else
            {
                e.Node.SetValue(_COL_WEIGHT, 0);
                checkChildren(e.Node, false);
                checkParent(e.Node);
            }
            _preventValueChangedEvent = false;
        }
    }
}