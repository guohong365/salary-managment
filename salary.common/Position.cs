using System.Collections.Generic;
using SalarySystem.Core;
using SalarySystem.Performance;

namespace SalarySystem
{
    public class Position : ItemBase, IPosition
    {
        private IPosition _leaderPosition;

        private readonly List<Employee> _employees=new List<Employee>(); 

        public virtual IPosition LeaderPosition
        {
            get { return _leaderPosition; }
            set { _leaderPosition = value; }
        }

        public IEnumerable<IEmployee> GetEmployees()
        {
                return _employees;
        }

        public List<Employee> Employees
        {
            get { return _employees; }
            
        }
        
        public void AddEmployee(IEmployee employee)
        {
            _employees.Add((Employee) employee);
        }

        public void AddEmployees(IEnumerable<IEmployee> employees)
        {
            _employees.AddRange((IEnumerable<Employee>) employees);
        }

        public void RemoveEmployee(IEmployee employee)
        {
            _employees.Remove((Employee) employee);
        }

        public void RemoveEmployeeById(string id)
        {
            IEmployee employee = FindEmployee(id);
            if (employee != null)
            {
                _employees.Remove((Employee) employee);
            }
        }

        public void RemoveAllEmployee()
        {
            _employees.Clear();
        }

        public IEmployee FindEmployee(string id)
        {
            return _employees.Find(item => item.Id == id);
        }

        readonly List<EvaluationForm> _evaluationForms=new List<EvaluationForm>();
        public List<EvaluationForm> EvaluationForms { get { return _evaluationForms; } }

        public IEnumerable<IEvaluationElement> GetEvaluation()
        {
            return _evaluationForms;
        }

        public void AddEvaluation(IEvaluationElement evaluationElement)
        {
            _evaluationForms.Add((EvaluationForm) evaluationElement);
        }

        public void AddEvaluations(IEnumerable<IEvaluationElement> evaluationElements)
        {
            _evaluationForms.AddRange((IEnumerable<EvaluationForm>) evaluationElements);
        }

        public void RemoveEvaluation(EvaluationForm evaluationElement)
        {
            _evaluationForms.Remove(evaluationElement);
        }

        public void RemoveEvaluationById(string id)
        {
            EvaluationForm form = _evaluationForms.Find(item => item.Id == id);
            if (form != null)
            {
                _evaluationForms.Remove(form);
            }
        }

        public void RemoveAllEvaluation()
        {
            _evaluationForms.Clear();
        }

        public IEvaluationElement FindEvaluationElement(string id)
        {
            return _evaluationForms.Find(item => item.Id == id);
        }

        public Position(string id,string name, string desc, IPosition leaderPosition)
            :base(id, name, desc, true)
        {
            _leaderPosition = leaderPosition;
        }

        public Position(string id,string name, string desc) : this(id,name, desc, null)
        {
            
        }

        public Position(string id, string name) : this(id, name, "")
        {
            
        }

        public Position() : this("", "")
        {
            
        }

        public string LeaderPositionId
        {
            get { return LeaderPosition == null ? "" : LeaderPosition.Id; }
        }

    }
}
