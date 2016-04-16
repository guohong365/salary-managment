using System;
using System.Data;

namespace SalarySystem.Schedule
{
    public class AssignmentScheduleDetailParameter
    {
        public int Year { get; set; }
        public int MonthFrom { get; set; }
        public int MonthTo { get; set; }
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemUnitName { get; set; }
        public DataTable AnnualSchedule { get; set; }
        public AssignmentScheduleDetailParameter(DataTable annualSchedule, string itemId, string unitName,
            string itemName, int monthFrom, int monthTo, int year)
        {
            Year = year;
            MonthFrom = monthFrom;
            MonthTo = monthTo;
            ItemId = itemId;
            ItemName = itemName;
            ItemUnitName = unitName;
            AnnualSchedule = annualSchedule;
        }

        public AssignmentScheduleDetailParameter(DataTable annualSchedule, string itemId, string unitName,
            string itemName, int monthFrom,int monthTo)
            : this(annualSchedule, itemId, unitName, itemName, monthFrom, monthTo, DateTime.Now.Year)
        {
            
        }

        public AssignmentScheduleDetailParameter(DataTable annualSchedule, string itemId, string unitName, string itemName, int monthFrom)
            : this(annualSchedule, itemId,unitName, itemName, monthFrom, 12)
        {
            
        }

        public AssignmentScheduleDetailParameter(DataTable annualSchedule, string itemId, string unitName)
            :this(annualSchedule, itemId, unitName, "", 1)
        {
            
        }

        public AssignmentScheduleDetailParameter():
            this(null,"", "")
        {
            
        }

    }
}