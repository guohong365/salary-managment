using System.Data;

namespace UC.Platform.UI.Editor
{
    public delegate void FillControls(int type, DataRow item);

    public delegate void Retrive(ref DataRow item);

    public interface IItemEditor
    {
        int EditType { get; set; }
        DataRow Row{get; set;}
        bool ValidateItem();
        event FillControls FillControls;
        event Retrive Retrive; 
    }
}
