using System;
using System.Collections.Generic;
using System.Linq;
using salary.impl;
using salary.performance.CSI;
using salary.performance.product;

namespace salary.main
{
   public static class DataHolder
   {
       static public List<IEmployee> Employees=new List<IEmployee>();
       public static List<IPosition> Positions=new List<IPosition>();
       public static List<IPositionSalaryLevel> SalaryLevels=new List<IPositionSalaryLevel>();
       public static List<IAppraisalElement> AppraisalElements=new List<IAppraisalElement>(); 
       public static List<IAppraisalCalculator> AppraisalCalculators=new List<IAppraisalCalculator>();
 
       public static void Init()
       {
           #region init appraisal calculator
           AppraisalCalculators.Add(new CSIAppraisalCalculator("001", "CSI", ""));
           AppraisalCalculators.Add(new ProductValueCalculator("002", "产值", ""));
           #endregion
           #region init appraisal indicator
           AppraisalElements.Add(new AppraisalElement("001", "CSI", AppraisalCalculators.Find(item=>item.Id=="001"), new Decimal(0.6)));
           AppraisalElements.Add(new AppraisalElement("002", "产值", AppraisalCalculators.Find(item=>item.Id=="002"), new Decimal(0.4)));
           #endregion

           #region init position

           Positions.Add(new Position("1000","服务主管"));
           Positions.Add(new Position("1001","使用接待", "", Positions.Find(item=> item.Id=="1000")));

           #endregion

           #region init salary level
           SalaryLevels.Add(new SalaryLevel("001", "服务主管A", Positions.Find(item=>item.Id=="1000"), 0));
           SalaryLevels.Add(new SalaryLevel("002", "服务主管B", Positions.Find(item => item.Id == "1000"), 1));
           SalaryLevels.Add(new SalaryLevel("003", "试用接待A", Positions.Find(item=>item.Id=="1001"), 0));
           #endregion

           #region init employee
           Employees.Add(new Employee("001", "张三", new DateTime(2010, 1, 31), Positions.Find(item=> item.Id=="1000"), SalaryLevels.Find(item=>item.Id=="001")));
           Employees.Add(new Employee("002", "李四", new DateTime(2016, 2, 1), Positions.Find(item=>item.Id=="1001"), SalaryLevels.Find(item=>item.Id=="003")));
           #endregion

       }

   }
}
