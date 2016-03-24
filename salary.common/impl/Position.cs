namespace salary.impl
{
    public class Position :IPosition
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IPosition LeaderPosition { get; set; }

        public Position(string id,string name, string desc, IPosition leaderPosition)
        {
            Id = id;
            Name = name;
            Description = desc;
            LeaderPosition = leaderPosition;
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
    }
}
