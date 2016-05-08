using System.Drawing;

namespace UC.Platform.UI
{
  public static class DataVisualizationColors
  {
    static DataVisualizationColors()
    {
      ChangedItemBackColor = Color.Yellow;
      ChangedItemForeColor = Color.Red;
    }
    public static Color ChangedItemBackColor { get; set; }
    public static Color ChangedItemForeColor { get; set; }
    
  }
}