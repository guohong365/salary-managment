using SalarySystem.Core;

namespace SalarySystem
{
    public class Position : ElementBase, IPosition
    {
        private IPosition _leaderPosition;

        public virtual IPosition LeaderPosition
        {
            get { return _leaderPosition; }
            set { _leaderPosition = value; }
        }

        public Position(string id,string name, string desc, IPosition leaderPosition)
            :base(id, name, 0, true, desc)
        {
            _leaderPosition = leaderPosition;
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

    }
}
