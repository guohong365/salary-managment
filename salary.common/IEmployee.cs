using System;

namespace salary
{
    public interface IEmployee
    {
        string Id { get; set; }
        string Name { get; set; }
        IPosition Position { get; set; }
        string LeaderId { get; }
        IEmployee Leader { get; set; }
        DateTime EntryTime { get; set; }
        int Seniority { get; }
        IPositionSalaryLevel SalaryLevel { get; set; }
    }
}
