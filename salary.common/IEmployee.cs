using System;

namespace salary
{
    public interface IEmployee : IItem
    {
        IPosition Position { get; set; }
        string LeaderId { get; }
        IEmployee Leader { get; set; }
        DateTime EntryTime { get; set; }
        int Seniority { get; }
        ISalaryLevel SalaryLevel { get; set; }
        bool Dimission { get; set; }
        DateTime DimissionTime { get; set; }

    }
}
