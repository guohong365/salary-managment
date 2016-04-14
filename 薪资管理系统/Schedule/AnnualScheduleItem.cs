using System.ComponentModel;

namespace SalarySystem.Schedule
{
    public class AnnualScheduleItem
    {
        [DisplayName("月份名称")]
        public string DispalyText
        {
            get
            {
                return string.Format("{0}月", Month);
            }
        }

        [DisplayName("月份")]
        public int Month { get; set; }
        [DisplayName("占比")]
        public decimal Rate { get; set; }
        [DisplayName("分配值")]
        public decimal Value { get; set; }
    }
}