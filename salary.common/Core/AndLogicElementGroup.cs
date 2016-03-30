using System.Linq;

namespace SalarySystem.Core
{
    public class AndLogicElementGroup : LogicElementGroup
    {
        public override bool Value
        {
            get
            {
                return GetEnumerable().All(item => item.Value!=0);
            }
        }

    }
}