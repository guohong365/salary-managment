using System.Collections.Generic;

namespace salary
{
   public interface IPositionSalaryLevel
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        IPosition Position { get; set; }
        int Level { get; set; }
        List<ISalaryElement> SalaryElements { get; set; }
    }
}
