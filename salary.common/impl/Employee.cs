using System;

namespace salary.impl
{
    public sealed class Employee : ItemBase, IEmployee
    {
        public IPosition Position { get; set; }
        public string LeaderId
        {
            get
            {
                if (Leader != null)
                {
                    return Leader.Id;
                }
                return null;
            }
        }

        public IEmployee Leader { get; set; }
        public DateTime EntryTime { get; set; }
        public int Seniority
        {
            get
            {
                DateTime currenTime = DateTime.Now;
                return (int) (currenTime.Subtract(EntryTime).Days/365.0);
            }
        }

        public ISalaryLevel SalaryLevel { get; set; }
        public bool Dimission { get; set; }
        public DateTime DimissionTime { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public Employee(string id, string name, DateTime entryTime, IPosition position, 
            ISalaryLevel salaryLevel, IEmployee leader)
        {
            Id = id;
            Name = name;
            EntryTime = entryTime;
            Leader = leader;
            Position = position;
            SalaryLevel = salaryLevel;
        }

        public Employee(string id, string name, DateTime entryTime, IPosition position, ISalaryLevel salaryLevel)
            : this(id, name, entryTime, position, salaryLevel, null)
        {

        }
    }
}
