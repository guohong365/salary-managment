using System.Configuration;
using MySql.Data.MySqlClient;
using SalarySystem.Data;
using UC.Platform.Data.DBHelper;

namespace SalarySystem
{
    public static class DataHolder
    {
        private static readonly DataSetSalary _dataSet = new DataSetSalary();

        static DataHolder()
        {
        }

        public static void InitAdapter()
        {
            DBHandlerEx.RegisterDBDefaultType(ConfigurationManager.ConnectionStrings[0]);
           // DBHandlerEx.RegisterDBDefaultType("MySql.Data.MySqlClient", "server=localhost;user id=root;persistsecurityinfo=True;database=salary;password=1111");
        }

        public static DataSetSalary DataSet
        {
            get { return _dataSet; }
        }

        #region 数据表

        public static DataSetSalary.t_annual_assignmentDataTable AnnualAssignment
        {
            get { return _dataSet.t_annual_assignment; }
        }

        public static DataSetSalary.t_assignment_defineDataTable AssignmentDefine
        {
            get { return _dataSet.t_assignment_define; }
        }

        public static DataSetSalary.t_assignment_item_typeDataTable AssignmentItemType
        {
            get { return _dataSet.t_assignment_item_type; }
        }

        public static DataSetSalary.t_assignment_performanceDataTable AssignmentPerformance
        {
            get { return _dataSet.t_assignment_performance; }
        }

        public static DataSetSalary.t_employeeDataTable Employee
        {
            get { return _dataSet.t_employee; }
        }

        public static DataSetSalary.t_employee_salary_detailDataTable EmployeeSalaryDetail
        {
            get { return _dataSet.t_employee_salary_detail; }
        }

        public static DataSetSalary.t_evaluation_formDataTable EvaluationForm
        {
            get { return _dataSet.t_evaluation_form; }
        }

        public static DataSetSalary.t_evaluation_form_itemsDataTable EvaluationFormItems
        {
            get { return _dataSet.t_evaluation_form_items; }
        }

        public static DataSetSalary.t_evaluation_itemDataTable EvaluationItem
        {
            get { return _dataSet.t_evaluation_item; }
        }

        public static DataSetSalary.t_evaluation_item_typeDataTable EvaluationItemType
        {
            get { return _dataSet.t_evaluation_item_type; }
        }

        public static DataSetSalary.t_evaluation_resultsDataTable EvaluationResults
        {
            get { return _dataSet.t_evaluation_results; }
        }

        public static DataSetSalary.t_evaluation_standardDataTable EvaluationStandard
        {
            get { return _dataSet.t_evaluation_standard; }
        }

        public static DataSetSalary.t_positionDataTable Position
        {
            get { return _dataSet.t_position; }
        }

        public static DataSetSalary.t_position_assignmentsDataTable PositionAssignments
        {
            get { return _dataSet.t_position_assignments; }
        }

        public static DataSetSalary.t_position_evaluation_formsDataTable PositionEvaluationForms
        {
            get { return _dataSet.t_position_evaluation_forms; }
        }

        public static DataSetSalary.t_position_salary_itemsDataTable PositionSalaryItems
        {
            get { return _dataSet.t_position_salary_items; }
        }

        public static DataSetSalary.t_repository_assignmentDataTable RepositoryAssignment
        {
            get { return _dataSet.t_repository_assignment; }
        }

        public static DataSetSalary.t_repository_evaluationDataTable RepositoryEvaluation
        {
            get { return _dataSet.t_repository_evaluation; }
        }

        public static DataSetSalary.t_repository_salary_structDataTable RepositorySalaryStruct
        {
            get { return _dataSet.t_repository_salary_struct; }
        }

        public static DataSetSalary.t_salary_data_source_typeDataTable SalaryDataSourceType
        {
            get { return _dataSet.t_salary_data_source_type; }
        }

        public static DataSetSalary.t_salary_itemDataTable SalaryItem
        {
            get { return _dataSet.t_salary_item; }
        }

        public static DataSetSalary.t_salary_item_typeDataTable SalaryItemType
        {
            get { return _dataSet.t_salary_item_type; }
        }

        public static DataSetSalary.t_settingsDataTable Settings
        {
            get { return _dataSet.t_settings; }
        }

        public static DataSetSalary.t_unitDataTable Unit
        {
            get { return _dataSet.t_unit; }
        }
        
        public static DataSetSalary.v_evaluation_form_detailDataTable EvaluationFormDetail
        {
            get { return _dataSet.v_evaluation_form_detail; }
        }
        
        public static DataSetSalary.v_salary_struct_detailDataTable SalaryStructDetail
        {
            get { return _dataSet.v_salary_struct_detail; }
        }
        #endregion

    }
}