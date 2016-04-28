using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SalarySystem.Data;

namespace SalarySystem.Execute
{
    public class EmployeePerformance
    {
        public DataSetSalary.t_employeeRow Employee { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string EvaluatorId { get; set; }
        public DateTime EvaluationTime { get; set; }

        public DataTable FormsIdName { get; set; }
        public IDictionary<string, DataSetSalary.v_evaluation_result_detailDataTable> EvaluationResults { get; private set; }

        public bool IsDirty
        {
            get
            {
                return EvaluationResults.Values.Any(item => item.Any(row => row.RowState != DataRowState.Unchanged)) ||
                       AssignmentPerformance.Any(item => item.RowState != DataRowState.Unchanged);
            }
        }

        public DataSetSalary.t_assignment_performanceDataTable AssignmentPerformance { get; set; }
        public EmployeePerformance()
        {
            EvaluationResults = new Dictionary<string, DataSetSalary.v_evaluation_result_detailDataTable>();
        }
    }
}