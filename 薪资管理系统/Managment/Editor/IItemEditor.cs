using System.Windows.Forms;
using DevExpress.XtraExport;
using SalarySystem.Core;

namespace SalarySystem.Managment.Editor
{
    public delegate void FillControls(int type, IItem item);

    public delegate void Retrive(ref IItem item);

    public interface IItemEditor
    {
        int EditType { get; set; }
        IItem Item{get; set;}
        bool ValidateItem();
        event FillControls FillControls;
        event Retrive Retrive; 
    }

    public interface IItemEditorFactory
    {
        ItemControl CreateEditorControl(IItem item, int editType);
    }
}
