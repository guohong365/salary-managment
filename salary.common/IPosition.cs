using System.Collections.Generic;
using SalarySystem.Core;
using SalarySystem.Performance;

namespace SalarySystem
{
    public interface IPosition : IItem
    {
        IPosition LeaderPosition { get; set; }

        IEnumerable<IEmployee> GetEmployees();
        void AddEmployee(IEmployee employee);
        void AddEmployees(IEnumerable<IEmployee> employees);
        void RemoveEmployee(IEmployee employee);
        void RemoveEmployeeById(string id);
        void RemoveAllEmployee();
        IEmployee FindEmployee(string id);

        IEnumerable<IEvaluationElement> GetEvaluation();
        void AddEvaluation(IEvaluationElement evaluationElement);
        void AddEvaluations(IEnumerable<IEvaluationElement> evaluationElements);
        void RemoveEvaluation(EvaluationForm evaluationElement);
        void RemoveEvaluationById(string id);
        void RemoveAllEvaluation();
        IEvaluationElement FindEvaluationElement(string id);
    }
}