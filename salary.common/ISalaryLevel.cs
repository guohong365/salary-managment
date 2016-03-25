using System.Collections.Generic;

namespace salary
{
   public interface ISalaryLevel : IElement
    {
        IPosition Position { get; set; }
        int Level { get; set; }
        List<ISalaryElement> SalaryElements { get; set; }
    }
}
