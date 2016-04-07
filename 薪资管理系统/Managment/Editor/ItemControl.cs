using System.ComponentModel;
using System.Data;
using DevExpress.XtraEditors;

namespace SalarySystem.Managment.Editor
{
    public partial class ItemControl : XtraUserControl, IItemEditor
    {
        [DesignOnly(true)]
        public ItemControl()
        {
            InitializeComponent();
        }

        protected ItemControl(DataRow item, int editType)
        {
            EditType = editType;
            InitializeComponent();
            FillControls += fillControls;
            Retrive += retriveData;
            Row = item;
        }

        private void fillControls(int editype, DataRow row)
        {
            textEditId.Text = row["ID"] as string;
            textEditName.Text = row["NAME"] as string;
            memoEditDesc.Text = row["DESCRIPTION"] as string;

        }

        private void retriveData(ref DataRow row)
        {
            row["ID"] = textEditId.Text.Trim();
            row["NAME"] = textEditName.Text.Trim();
            row["DESCRIPTION"] = memoEditDesc.Text.Trim();
        }

        public int EditType { get; set; }
        private DataRow _row;

        [Browsable(false)]
        public DataRow Row
        {
            get
            {
                onRetrive(ref _row);
                return _row;
            }
            set
            {
                _row = value;
                onFillControls(EditType, _row);
            }
        }

        public virtual bool ValidateItem()
        {
            return true;
        }

        public event FillControls FillControls;

        protected virtual void onFillControls(int type, DataRow row)
        {
            FillControls handler = FillControls;
            if (handler != null) handler(type, row);
        }

        public event Retrive Retrive;

        protected virtual void onRetrive(ref DataRow row)
        {
            Retrive handler = Retrive;
            if (handler != null) handler(ref row);
        }

        private class FactoryClass : IItemEditorFactory
        {
            public ItemControl CreateEditorControl(DataRow row, int editType)
            {
                return new ItemControl(row, editType);
            }
        }

        public static IItemEditorFactory GetFactory()
        {
            return new FactoryClass();
        }
    }
}
