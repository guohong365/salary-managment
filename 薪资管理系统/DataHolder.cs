using System.Configuration;
using MySql.Data.MySqlClient;
using SalarySystem.Data;

namespace SalarySystem
{
    public static class DataHolder
    {
        private static readonly DataSetSalary _dataSet = new DataSetSalary();

        static DataHolder()
        {
        }

        public static DataSetSalary DataSet
        {
            get { return _dataSet; }
        }

        #region 数据表

        public static DataSetSalary.t_assignment_defineDataTable AssignmentDefine
        {
            get { return _dataSet.t_assignment_define; }
        }

        public static DataSetSalary.t_assignment_item_typeDataTable AssignmentItemType
        {
            get { return _dataSet.t_assignment_item_type; }
        }


        public static DataSetSalary.t_employeeDataTable Employee
        {
            get { return _dataSet.t_employee; }
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

        public static DataSetSalary.t_evaluation_standardDataTable EvaluationStandard
        {
            get { return _dataSet.t_evaluation_standard; }
        }

        public static DataSetSalary.t_positionDataTable Position
        {
            get { return _dataSet.t_position; }
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
        
        #endregion

    }
}