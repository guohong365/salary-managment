namespace SalarySystem.Salary
{
    public class SalaryDetail
    {
        /// <summary>
        /// 员工姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 员工岗位Id
        /// </summary>
        public string Position { get; set; } //岗位ID
        /// <summary>
        /// 工龄
        /// </summary>
        public string Seniority { get; set; }
        /// <summary>
        /// 基本工资
        /// </summary>
        public decimal BasicWage { get; set; }
        /// <summary>
        /// 工龄工资
        /// </summary>
        public decimal SeniorityWage { get; set; }
        /// <summary>
        /// 绩效工资
        /// </summary>
        public decimal PerfromanceBounses { get; set; }
 
        /// <summary>
        /// 精品辅料完成度
        /// </summary>
        public decimal EliteProductsCompleted { get; set; }
        /// <summary>
        /// 精品辅料提成比例
        /// </summary>
        public decimal EliteProductsPercentage { get; set; }
        /// <summary>
        /// 精品辅料提成
        /// </summary>
        public decimal EliteProductsCommision { get; set; }

        

    }
}