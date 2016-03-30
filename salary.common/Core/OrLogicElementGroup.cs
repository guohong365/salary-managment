using System.Linq;

namespace SalarySystem.Core
{
    public class OrLogicElementGroup : LogicElementGroup
    {
        public override bool Value
        {
            get
            {
                return GetEnumerable().Any(element => element.Value==0);
            }
        }
    }
}