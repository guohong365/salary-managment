namespace salary.impl
{
    public sealed class Position : ElementBase, IPosition
    {
        public IPosition LeaderPosition { get; set; }
        public string LeaderPositionId
        {
            get
            {
                return LeaderPosition != null ? LeaderPosition.Id : null;
            }
        }

        public Position(string id,string name, string desc, IPosition leaderPosition)
        {
            Id = id;
            Name = name;
            Description = desc;
            LeaderPosition = leaderPosition;
            Enabled = true;
        }

        public Position(string id,string name, string desc) : this(id,name, desc, null)
        {
            
        }

        public Position(string id, string name) : this(id, name, "")
        {
            
        }

        public Position() : this("", "")
        {
            
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Ready
        {
            get { return Enabled; }
        }
    }
}
