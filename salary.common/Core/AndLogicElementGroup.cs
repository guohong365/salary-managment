using System.Linq;

namespace SalarySystem.Core
{
    public class AndLogicElementGroup : LogicElementGroup
    {
        public override bool Value
        {
            get
            {
                return Elements.All(element => (bool) element.Value);
            }
            set { }
        }

    }
}