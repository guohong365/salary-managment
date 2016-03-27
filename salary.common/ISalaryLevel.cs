using System.Collections.Generic;
using SalarySystem.Core;

namespace SalarySystem
{
   public interface ISalaryLevel : IElement
    {
        IPosition Position { get; set; }
        int Level { get; set; }
        List<ISalaryElement> SalaryElements { get; set; }
    }
}
