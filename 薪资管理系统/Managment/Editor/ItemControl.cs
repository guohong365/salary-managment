using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SalarySystem.Core;

namespace SalarySystem.Managment.Editor
{
    public partial class ItemControl : XtraUserControl, IItemEditor
    {
        [DesignOnly(true)]
        public ItemControl()
        {
            InitializeComponent();
        }

        protected ItemControl(IItem item, int editType)
        {
            EditType = editType;
            InitializeComponent();
            FillControls += fillControls;
            Retrive += retriveData;
            Item = item;
        }

        private void fillControls(int editype, IItem item)
        {
            textEditId.Text = item.Id;
            textEditName.Text = item.Name;
            memoEditDesc.Text = item.Description;

        }

        private void retriveData(ref IItem item)
        {
            item.Id = textEditId.Text.Trim();
            item.Name = textEditName.Text.Trim();
            item.Description = memoEditDesc.Text.Trim();
        }

        public int EditType { get; set; }
        private IItem _item;

        [Browsable(false)]
        public IItem Item
        {
            get
            {
                onRetrive(ref _item);
                return _item;
            }
            set
            {
                _item = value;
                onFillControls(EditType, _item);
            }
        }

        public virtual bool ValidateItem()
        {
            return string.IsNullOrEmpty(Item.Id) && string.IsNullOrEmpty(Item.Name);
        }

        public event FillControls FillControls;

        protected virtual void onFillControls(int type, IItem item)
        {
            FillControls handler = FillControls;
            if (handler != null) handler(type, item);
        }

        public event Retrive Retrive;

        protected virtual void onRetrive(ref IItem item)
        {
            Retrive handler = Retrive;
            if (handler != null) handler(ref item);
        }

        private class FactoryClass : IItemEditorFactory
        {
            public ItemControl CreateEditorControl(IItem item, int editType)
            {
                return new ItemControl(item, editType);
            }
        }

        public static IItemEditorFactory GetFactory()
        {
            return new FactoryClass();
        }
    }
}
