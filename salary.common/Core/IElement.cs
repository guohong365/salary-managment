using System.Windows.Forms.VisualStyles;

namespace SalarySystem.Core
{
    public interface IElement : IItem
    {
        decimal Weight { get; set; }
        decimal Value { get; set; }
    }

    public interface IElement<T> : IItem
    {
        bool Value { get; set; }
    }
}
