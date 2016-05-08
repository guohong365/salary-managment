using System.Data;

namespace UC.Platform.UI.Editor
{
  public interface IItemEditorFactory
  {
    IItemEditor CreateEditorControl(DataRow item, int editType);
  }
}