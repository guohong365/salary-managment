using System;
using SalarySystem.Core;

namespace SalarySystem
{
    public class Employee : ItemBase, IEmployee
    {
        private IPosition _position;
        private IEmployee _leader;
        private DateTime _entryTime;
        private ISalaryLevel _salaryLevel;
        private DateTime _dismissionTime;

        public virtual IPosition Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public virtual IEmployee Leader
        {
            get { return _leader; }
            set { _leader = value; }
        }

        public virtual DateTime EntryTime
        {
            get { return _entryTime; }
            set { _entryTime = value; }
        }

        public virtual int Seniority
        {
            get
            {
                DateTime currenTime = DateTime.Now;
                return (int) (currenTime.Subtract(EntryTime).Days/365.0);
            }
        }

        public virtual ISalaryLevel SalaryLevel
        {
            get { return _salaryLevel; }
            set { _salaryLevel = value; }
        }

        public virtual bool Dimission
        {
            get { return _dismissionTime!=DateTime.MinValue; }
        }

        public virtual DateTime DimissionTime { get { return _dismissionTime; } set { _dismissionTime = value; } }

        public Employee(string id, string name, DateTime entryTime, IPosition position, 
            ISalaryLevel salaryLevel, IEmployee leader, bool enabled, string description):
            base(id, name, description, enabled)
        {
            _entryTime = entryTime;
            _leader = leader;
            _position = position;
            _salaryLevel = salaryLevel;
            _dismissionTime = DateTime.MinValue;
        }

        public Employee(string id, string name, DateTime entryTime, IPosition position, ISalaryLevel salaryLevel)
            : this(id, name, entryTime, position, salaryLevel, null, true, "")
        {

        }

        public Employee() :
            this("", "", DateTime.Now, null, null, null, true, "")
        {
            
        }

        public override bool Ready
        {
            get
            {
                return !string.IsNullOrEmpty(Id) && 
                    !string.IsNullOrEmpty(Name) && 
                    Position != null && 
                    SalaryLevel != null;
            }
        }

        public override bool Enabled
        {
            get
            {
                return !Dimission && base.Enabled;
            }
            set
            {
                base.Enabled = value;
            }
        }
    }
}
