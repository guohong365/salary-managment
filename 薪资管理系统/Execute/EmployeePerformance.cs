using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SalarySystem.Data;
using UC.Platform.Data;

namespace SalarySystem.Execute
{
    public class EmployeePerformance
    {
        public DataSetSalary.t_employeeRow Employee { get; private set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string EvaluatorId { get; set; }
        public DateTime EvaluationTime { get; set; }

        public DataTable FormsIdName { get; private set; }
        public IDictionary<string, DataSetSalary.v_evaluation_result_detailDataTable> EvaluationResults { get; private set; }

        public Dictionary<string, DataTable> AssignmentResults { get; private set; } 

        public bool IsDirty
        {
            get
            {
                return EvaluationResults.Values.Any(item=>item.Any(row=>row.RowState!= DataRowState.Unchanged));
            }
        }

        public EmployeePerformance(
            DataSetSalary.t_employeeRow employee, 
            DataTable formsIdName, string evaluatorId,
            int year, int month, DateTime evaluationTime)
        {
            EvaluationTime = evaluationTime;
            FormsIdName = formsIdName;
            EvaluatorId = evaluatorId;
            Month = month;
            Year = year;
            Employee = employee;
            EvaluationResults = new Dictionary<string, DataSetSalary.v_evaluation_result_detailDataTable>();
            AssignmentResults=new Dictionary<string, DataTable>();
        }

        public EmployeePerformance(DataSetSalary.t_employeeRow employee, 
            DataTable formsIdName, string evaluatorId):this(employee, formsIdName, evaluatorId,
            DateTime.Now.Year, DateTime.Now.Month, DateTime.Now)
        {
        }


    }
}