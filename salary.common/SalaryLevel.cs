using System.Collections.Generic;
using System.Linq;
using SalarySystem.Core;

namespace SalarySystem
{
   public sealed class SalaryLevel : ElementBase, ISalaryLevel
    {
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

       public override bool Ready
       {
           get
           {
               return SalaryElements.All(item=> item.Ready) && SalaryElements.Count >0;
           }
       }
    }
}
