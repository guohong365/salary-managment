using System.Collections.Generic;
using System.ComponentModel;

namespace SalarySystem.Schedule
{
    public class AnnualSchedule
    {
        private readonly AnnualScheduleItem[] _monthValues = new AnnualScheduleItem[12];

        public AnnualSchedule(IList<decimal> rates)
        {
            SetWeights(rates);
        }

        public AnnualSchedule()
        {
            SetWeights(new decimal[]{0,0,0,0,0,0,0,0,0,0,0,0});
        }

        public void SetWeights(IList<decimal> rates)
        {
            for (var i = 0; i < 12; i++)
            {
                if (_monthValues[i] == null)
                {
                    _monthValues[i] = new AnnualScheduleItem();
                    _monthValues[i].Month = i + 1;
                    _monthValues[i].Value = 0;
                }
                _monthValues[i].Rate = (rates!=null && i < rates.Count) ? rates[i] : 0;
            }
        }
        [DisplayName("年度")]
        public int Year { get; set; }
        [DisplayName("任务编号")]
        public string Id { get; set; }
        [DisplayName("任务名称")]
        public string Name{get; set;}
        [DisplayName("任务额度")]
        public decimal AnnualValue { get; set; }
        
        [Category("月度分配情况")]
        public AnnualScheduleItem[] MonthValues
        {
            get
            {
                return _monthValues;
            }
        }

        public AnnualScheduleItem this[int index]
        {
            get { return MonthValues[index]; }
            set { MonthValues[index] = value; }
        }
    }
}
