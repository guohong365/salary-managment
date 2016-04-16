using System.Data;
using System.Drawing;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using SalarySystem.Data;
using UC.Platform.Data;


namespace SalarySystem.Managment.Assignment
{
    public partial class AutoAssignmentRateDefineControl : BaseEditableControl
    {
        public AutoAssignmentRateDefineControl()
        {
            InitializeComponent();
        }

        private readonly DataSetSalary.v_team_assignment_detailDataTable _dataView=new DataSetSalary.v_team_assignment_detailDataTable();
        protected override void onControlLoad()
        {
            base.onControlLoad();

            gridControlAssignmentDefine.DataSource = new DataView(DataHolder.AssignmentDefine)
            {
                RowFilter = string.Format("[ENABLED]=true AND [TYPE]='{0}'", GlobalSettings.TYPE_ASSIGNMENT_AUTO_ASSIGN)
            };

            //_dataView=new DataSetSalary.v_team_assignment_detailDataTable();
            //DBHandlerEx.FillOnce(_dataView, "select * from v_team_assignment_detail");
            //treeList1.DataSource = _dataView;
            //treeList1.ExpandAll();
            _dataView.RowChanged += onRowChanged;
            repositoryItemLookUpEdit1.DataSource = DataHolder.Position;
            treeList1.CustomDrawNodeCell += GridViewHelper.CustomDrawNodeCell;
            treeList1.ExpandAll();
        }

        protected override void onControlReload()
        {
            base.onControlReload();
            _dataView.RowChanged += onRowChanged;
            treeList1.ExpandAll();

        }

        protected override void onControlUnload()
        {
            base.onControlUnload();
            _dataView.RowChanged -= onRowChanged;
        }

        protected override void onSave()
        {
            base.onSave();
            foreach (DataSetSalary.v_team_assignment_detailRow row in _dataView)
            {
                var dataRow = DataHolder.PositionAssignments.FindByASSIGNMENT_IDPOSITION_ID(row.DEFINE_ID, row.ID);
                if (dataRow != null)
                {
                    dataRow.WEIGHT = 100;
                    dataRow.ENABLED = row.USED;
                    dataRow.VALUE = row.WEIGHT;
                }
                else
                {
                    dataRow = DataHolder.PositionAssignments.Newt_position_assignmentsRow();
                    dataRow.ASSIGNMENT_ID = row.DEFINE_ID;
                    dataRow.POSITION_ID = row.ID;
                    dataRow.WEIGHT = 100;
                    dataRow.VERSION_ID = row.VERSION_ID;
                    dataRow.ENABLED = row.USED;
                    dataRow.VALUE = row.WEIGHT;
                    DataHolder.PositionAssignments.Addt_position_assignmentsRow(dataRow);
                }
            }
            DBHandlerEx.UpdateOnce(DataHolder.PositionAssignments);
            _dataView.AcceptChanges();
        }

        protected override void onRevert()
        {
            base.onRevert();
            _dataView.RejectChanges();
        }

        void checkChildren(TreeListNode thisNode, bool used)
        {
            if(!thisNode.HasChildren) return;
            decimal val=100;
            decimal last=100;
            if (used)
            {
                val = (decimal)((int)((100.0/thisNode.Nodes.Count)*100))/100;
                last = 100 - val*thisNode.Nodes.Count + val;
            }
            TreeListNode node = thisNode.FirstNode;
            while(node!=null)
            {
                node.SetValue("WEIGHT", used ?(node.NextNode==null ? last : val) : 0);
                node.SetValue("USED", used);
                checkChildren(node, used);
                node = node.NextNode;
            }

        }

        void checkParent(TreeListNode thisNode, bool used)
        {
            TreeListNode parentNode = thisNode.ParentNode;
            if(parentNode==null) return;

            //处理自身值的问题
            if ((bool) parentNode.GetValue("USED")) //本身就是选中的
            {
                if (used) return; //啥也不做

                //如果是反选
                //查找其他兄弟是否有选中的，如有，返回。
                if (thisNode.ParentNode.Nodes.Cast<TreeListNode>()
                    .Any(brother => brother != thisNode && (bool) brother.GetValue("USED")))
                {
                    return;
                }
                parentNode.SetValue("WEIGHT", 0);
            }
            else
            {
                if (!used) return; //貌似不可能
                recalcWeight(parentNode);
            }
            parentNode.SetValue("USED", used);
            checkParent(parentNode, used);
            
        }

        private void focusedAssignmentDefinChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridViewAssignmentDefine.GetDataRow(e.FocusedRowHandle);
            if (row != null)
            {
                _dataView.Clear();
                string sql=string.Format("select * from v_team_assignment_detail where DEFINE_ID='{0}'", row["ID"]);

                int ret=DBHandlerEx.FillOnce(_dataView, sql);
                    
                treeList1.DataSource = _dataView;
                treeList1.ExpandAll();
            }
            else
            {
                treeList1.DataSource = null;
            }
        }

        private readonly Color[] _colors = new[]
        {
            Color.Blue,
            Color.Green,
            Color.Yellow,
            Color.Salmon,
            Color.Teal,
            Color.RoyalBlue
        };

        private void customDrawRowFooterCell(object sender, DevExpress.XtraTreeList.CustomDrawRowFooterCellEventArgs e)
        {
            if(e.Text==string.Empty) return;

            if (e.Column.FieldName == "WEIGHT" && e.Node.ParentNode!=null)
            {
                decimal val = (decimal) treeList1.GetGroupSummaryValue(e.Column, e.Node.ParentNode.Nodes); 
                if(val > 100)
                {
                    e.Appearance.ForeColor = Color.Red;
                }
            }
        }

        void recalcWeight(TreeListNode node)
        {
            TreeListNodes brothers = node.ParentNode != null ? node.ParentNode.Nodes : node.RootNode.Nodes;

            decimal sum = 0;
            decimal newValue = 0;
            if (brothers.Count > 2)
            {
                sum += (from TreeListNode brother in brothers where brother != node select (decimal) brother.GetValue("WEIGHT")).Sum();
                if (sum < 100)
                {
                    newValue = 100 - sum;
                }
            }
            else
            {
                newValue = 100;
            }
            node.SetValue("WEIGHT", newValue);
        }

        private void cellValueChange(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName=="USED")
            {
                if ((bool) e.Value)
                {
                    recalcWeight(e.Node);
                    checkParent(e.Node, true);
                }
                else
                {
                    checkChildren(e.Node, false);
                }
            }

        }
    }
}
