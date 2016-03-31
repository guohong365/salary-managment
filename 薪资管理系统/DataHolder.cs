using System.Collections.Generic;
using SalarySystem.Core;
using SalarySystem.Data;
using SalarySystem.Data.SalaryDataSetTableAdapters;
using SalarySystem.Performance;

namespace SalarySystem
{
   public static class DataHolder
   {
       static readonly SalaryDataSet _dataSet = new SalaryDataSet();
       static readonly TableAdapterManager _adapterManager=new TableAdapterManager();

       public static TableAdapterManager AdapterManager
       {
           get { return _adapterManager; }
       }

       public static SalaryDataSet DataSet
       {
           get { return _dataSet; }
       }

       static public List<IEmployee> Employees=new List<IEmployee>();
       public static List<Position> Positions=new List<Position>();
       public static List<ISalaryLevel> SalaryLevels=new List<ISalaryLevel>();
       public static List<IElement> AppraisalElements=new List<IElement>();

       public static void AddEmployeeToPosition(string positionId, IEmployee employee)
       {
           Position position=Positions.Find(item => item.Id == positionId);
           if (position != null)
           {
               employee.Position = position;
               position.AddEmployee(employee);
           }
       }

       public static void AddEvaluationFormToPosition(string positionId, IEvaluationFormItem formItem)
       {
           Position position = Positions.Find(item => item.Id == positionId);
           if (position != null)
           {
               position.AddEvaluation(formItem);
           }

       }
       public static void Init()
       {
           #region init position
           
           AdapterManager.t_positionTableAdapter.Fill(_dataSet.t_position);

           #endregion

           //#region init salary level
           //SalaryLevels.Add(new SalaryLevel("001", "服务主管A", Positions.Find(item=>item.Id=="1000"), 0));
           //SalaryLevels.Add(new SalaryLevel("002", "服务主管B", Positions.Find(item => item.Id == "1000"), 1));
           //SalaryLevels.Add(new SalaryLevel("003", "试用接待A", Positions.Find(item=>item.Id=="1001"), 0));
           //#endregion

           //#region init employee
           //Employees.Add(new Employee("001", "张三", new DateTime(2010, 1, 31), Positions.Find(item=> item.Id=="1000"), SalaryLevels.Find(item=>item.Id=="001")));
           //Employees.Add(new Employee("002", "李四", new DateTime(2016, 2, 1), Positions.Find(item=>item.Id=="1001"), SalaryLevels.Find(item=>item.Id=="003"), Employees.Find(item=>item.Id=="001")));
           //#endregion

       }

   }
}
