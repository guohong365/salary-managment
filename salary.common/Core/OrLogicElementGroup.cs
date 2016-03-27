using System.Linq;

namespace SalarySystem.Core
{
    public class OrLogicElementGroup : LogicElementGroup
    {
        public override bool Value {
            get
            { return Elements.Any(element => (bool) element.Value); }
            set { }
        }
    }
}