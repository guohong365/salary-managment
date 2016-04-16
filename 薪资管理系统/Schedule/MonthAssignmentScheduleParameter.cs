namespace SalarySystem.Schedule
{
    public class MonthAssignmentScheduleParameter
    {
        public MonthAssignmentScheduleParameter(string itemId, int year, int month)
        {
            Month = month;
            Year = year;
            ItemId = itemId;
        }

        public int Year { get; private set; }
        public int Month { get; private set; }
        public string ItemId { get;private set; }
    }
}