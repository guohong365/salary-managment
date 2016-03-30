using System;

namespace SalarySystem.Core
{
    public interface IItem : ICloneable, ICopyable, IComparable
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        bool Ready { get; }
        bool Enabled { get; set; }
    }
}
