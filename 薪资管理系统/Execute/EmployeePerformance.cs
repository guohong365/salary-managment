using System;
using System.Collections.Generic;
using System.Data;
using SalarySystem.Data;

namespace SalarySystem.Execute
{
    public class EmployeePerformance
    {
        private bool _dirty;
        public DataSetSalary.t_employeeRow Employee { get; private set; }
        public DataTable FormsIdName { get; private set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string EvaluatorId { get; set; }
        public DateTime EvaluationTime { get; set; }
        public IDictionary<string, DataTable> Results { get; private set; }

        public bool IsDirty
        {
            get
            {
                return _dirty;
            }
            set
            {
                _dirty = value;
                onDirtyChanged();
            } 
        }

        public event EventHandler DirtyChanged;

        protected virtual void onDirtyChanged()
        {
            EventHandler handler = DirtyChanged;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        public EmployeePerformance(
            DataSetSalary.t_employeeRow employee, 
            DataTable formsIdName, string evaluatorId,
            int year, int month, DateTime evaluationTime)
        {
            EvaluationTime = evaluationTime;
            _dirty = false;
            FormsIdName = formsIdName;
            EvaluatorId = evaluatorId;
            Month = month;
            Year = year;
            Employee = employee;
            Results = new Dictionary<string, DataTable>();
        }

        public EmployeePerformance(DataSetSalary.t_employeeRow employee, 
            DataTable formsIdName, string evaluatorId):this(employee, formsIdName, evaluatorId,
            DateTime.Now.Year, DateTime.Now.Month, DateTime.Now)
        {
        }
    }
}