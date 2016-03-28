using System;

namespace SalarySystem.Core
{
    public class ItemBase :IItem, ICopyable<IItem>
    {
        private string _id;
        private string _name;
        private string _description;
        private bool _enabled;

        protected ItemBase(string id, string name, string description, bool enabled)
        {
            _id = id;
            _name = name;
            _description = description;
            _enabled = enabled;
        }

        protected ItemBase(string id, string name, string description) : this(id, name, description, true)
        {
            
        }

        protected ItemBase(string id, string name) : this(id, name, "")
        {
            
        }
        protected ItemBase()
        {
            _id = "";
            _name = "";
            _description = "";
            _enabled = true;
        }

        public virtual string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual string Name { get { return _name; } set { _name = value; } }
        public virtual string Description { get { return _description; } set { _description = value; } }
        public virtual bool Ready { get { return !string.IsNullOrEmpty(Id) && !string.IsNullOrEmpty(Name); }}
        public virtual bool Enabled { get { return _enabled; } set { _enabled = value; } }
        
        public virtual IItem CopyFrom(IItem anther)
        {
            _id = anther.Id;
            _name = anther.Name;
            _description = anther.Description;
            _enabled = anther.Enabled;
            return this;
        }

        public override string ToString()
        {
            return Name;
        }

        public virtual object CopyFrom(object another)
        {
            return CopyFrom((IItem)another);
        }

        public virtual object Clone()
        {
            ItemBase item = (ItemBase)Activator.CreateInstance(GetType());
            return item.CopyFrom(this);
        }
    }
}
