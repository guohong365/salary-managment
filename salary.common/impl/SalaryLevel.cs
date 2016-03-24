using System.Collections.Generic;

namespace salary.impl
{
   public class SalaryLevel : IPositionSalaryLevel
    {
       public string Id { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public IPosition Position { get; set; }
       public int Level { get; set; }
       public List<ISalaryElement> SalaryElements { get; set; }
       public override string ToString()
       {
           return Name;
       }

       public SalaryLevel(string id, string name, IPosition position,int level, string desc)
       {
           Id = id;
           Name = name;
           Description = desc;
           Position = position;
           Level = level;
       }

       public SalaryLevel(string id, string name, IPosition position, int level) : this(id, name, position, level, "")
       {
           
       }

       public SalaryLevel(string id, string name) : this(id, name, null, 0)
       {
           
       }
    }
}
