using System;
using System.Collections.Generic;
using SalarySystem.Core;
using SalarySystem.Performance;

namespace SalarySystem
{
   public static class DataHolder
   {
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
           //#region init appraisal calculator
           ////AppraisalCalculators.Add(new CSIAppraisalCalculator("001", "CSI", ""));
           ////AppraisalCalculators.Add(new ProductValueCalculator("002", "产值", ""));
           //#endregion
           //#region init appraisal indicator
           //AppraisalElements.Add(new AppraisalElement("001", "CSI", AppraisalCalculators.Find(item=>item.Id=="001"), new Decimal(0.6)));
           //AppraisalElements.Add(new AppraisalElement("002", "产值", AppraisalCalculators.Find(item=>item.Id=="002"), new Decimal(0.4)));
           //#endregion

           #region init position

           Positions.Add(new Position("0000000000", "总经理"));
           AddEmployeeToPosition("0000000000", new Employee("0001", "邹伟", new DateTime(1998, 1, 1), null, null));
           Positions.Add(new Position("0100000000", "客服经理", "",      Positions.Find(item => item.Id == "0000000000")));
           Positions.Add(new Position("0101000000", "顾客管理员", "",    Positions.Find(item => item.Id == "0100000000")));
           Positions.Add(new Position("0102000000", "信息员", "",        Positions.Find(item => item.Id == "0100000000")));
           Positions.Add(new Position("0200000000", "服务总监", "",      Positions.Find(item => item.Id == "0000000000")));
           Positions.Add(new Position("0201000000", "保险部经理", "",    Positions.Find(item => item.Id == "0200000000")));
           Positions.Add(new Position("0201010000", "事故专员", "",      Positions.Find(item => item.Id == "0201000000")));
           Positions.Add(new Position("0201020000", "电话车险销售员", "",Positions.Find(item => item.Id == "0201000000")));
           Positions.Add(new Position("0202000000", "服务经理", "",      Positions.Find(item => item.Id == "0200000000")));
           EvaluationForm form=new EvaluationForm("001", "KPI", "");
           form.Items.Add(new EvaluationFormItem("001", "考核1", "考核1", 5));
           form.Items.Add(new EvaluationFormItem("002", "考核2", "考核2", 5));
           AddEvaluationFormToPosition("0202000000", form);
           form = new EvaluationForm("002", "TQC", "");
           form.Items.Add(new EvaluationFormItem("001", "考核1", "考核1", 5));
           form.Items.Add(new EvaluationFormItem("002", "考核2", "考核2", 5));
           AddEvaluationFormToPosition("0202000000", form);
           form = new EvaluationForm("003", "FFC", "");
           form.Items.Add(new EvaluationFormItem("001", "考核1", "考核1", 5));
           form.Items.Add(new EvaluationFormItem("002", "考核2", "考核2", 5));
           AddEvaluationFormToPosition("0202000000", form);
           Positions.Add(new Position("0202010000", "非技术内训师", "",  Positions.Find(item => item.Id == "0202000000")));
           Positions.Add(new Position("0202020000", "索赔员", "",        Positions.Find(item => item.Id == "0202000000")));
           Positions.Add(new Position("0202030000", "前台主管", "",      Positions.Find(item => item.Id == "0202000000")));
           Positions.Add(new Position("0202030100", "服务顾问", "",      Positions.Find(item => item.Id == "0202030000")));
           Positions.Add(new Position("0203030101", "实习服务顾问", "",  Positions.Find(item => item.Id == "0202030100")));
           Positions.Add(new Position("0202030200", "休息区服务专员", "",Positions.Find(item => item.Id == "0202030000")));
           Positions.Add(new Position("0202040000", "网络管理员", "",    Positions.Find(item => item.Id == "0202000000")));
           Positions.Add(new Position("0203000000", "配件经理", "",      Positions.Find(item => item.Id == "0200000000")));
           Positions.Add(new Position("0203010000", "库管员", "",        Positions.Find(item => item.Id == "0203000000")));
           Positions.Add(new Position("0203020000", "配件计划员", "",    Positions.Find(item => item.Id == "0203000000")));
           Positions.Add(new Position("0204000000", "技术经理", "",      Positions.Find(item => item.Id == "0200000000")));
           Positions.Add(new Position("0204010000", "技术内训师", "",    Positions.Find(item => item.Id == "0204000000")));
           Positions.Add(new Position("0204020000", "质检员", "",        Positions.Find(item => item.Id == "0204000000")));
           Positions.Add(new Position("0204030000", "车间主管", "",      Positions.Find(item => item.Id == "0204000000")));
           Positions.Add(new Position("0204030100", "机电组长", "",      Positions.Find(item => item.Id == "0204030000")));
           Positions.Add(new Position("0204030101", "机电技师", "",      Positions.Find(item => item.Id == "0204030100")));
           Positions.Add(new Position("0204030102", "机电学徒", "",      Positions.Find(item => item.Id == "0204030100")));
           Positions.Add(new Position("0204030200", "钣金组长", "",      Positions.Find(item => item.Id == "0204030000")));
           Positions.Add(new Position("0204030201", "钣金技师", "",      Positions.Find(item => item.Id == "0204030200")));
           Positions.Add(new Position("0204030202", "钣金学徒", "",      Positions.Find(item => item.Id == "0204030200")));
           Positions.Add(new Position("0204030300", "漆工组长", "",      Positions.Find(item => item.Id == "0204030000")));
           Positions.Add(new Position("0204030301", "漆工技师", "",      Positions.Find(item => item.Id == "0204030300")));
           Positions.Add(new Position("0204030302", "漆工学徒", "",      Positions.Find(item => item.Id == "0204030300")));
           Positions.Add(new Position("0204040000", "PDI专员", "",       Positions.Find(item => item.Id == "0204000000")));
           Positions.Add(new Position("0204050000", "救急专员", "",      Positions.Find(item => item.Id == "0204000000")));
           Positions.Add(new Position("0204060000", "废料收集员", "",    Positions.Find(item => item.Id == "0204000000")));

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
