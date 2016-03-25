namespace salary
{
    public abstract class ItemBase :IItem
    {
        private string _id;
        private string _name;
        private string _description;
        private bool _enabled;
        private bool _ready;

        protected ItemBase(string id, string name, string description, bool enabled, bool ready)
        {
            _id = id;
            _name = name;
            _description = description;
            _enabled = enabled;
            _ready = ready;
        }

        protected ItemBase(string id, string name, string description, bool enabled):this(id, name, description, enabled, true)
        {
            
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
            _ready = true;
            _enabled = true;
        }

        public virtual string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual string Name { get { return _name; } set { _name = value; } }
        public virtual string Description { get { return _description; } set { _description = value; } }
        public virtual bool Ready { get { return _ready; } protected set { _ready = value; }}
        public virtual bool Enabled { get { return _enabled; } set { _enabled = value; } }
    }
}
