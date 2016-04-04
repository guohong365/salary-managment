﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SalarySystem.Data;
using SalarySystem.Data.DataSetSalaryTableAdapters;

namespace SalarySystem
{
    public static class DataHolder
    {
        private static readonly DataSetSalary _dataSet = new DataSetSalary();
        private static readonly TableAdapterManager _adapterManager = new TableAdapterManager();
        private static readonly List<Type> _adapterTypes = new List<Type>();

        static DataHolder()
        {
            _adapterTypes.AddRange(new[]
            {
                typeof (t_assignment_itemTableAdapter),
                typeof(t_assignment_item_typeTableAdapter),
                typeof (t_assignment_performanceTableAdapter),
                typeof (t_employeeTableAdapter),
                typeof (t_employee_salary_detailTableAdapter),
                typeof (t_evaluation_formTableAdapter),
                typeof (t_evaluation_form_itemsTableAdapter),
                typeof (t_evaluation_itemTableAdapter),
                typeof (t_evaluation_item_typeTableAdapter),
                typeof (t_evaluation_resultsTableAdapter),
                typeof (t_evaluation_standardTableAdapter),
                typeof (t_positionTableAdapter),
                typeof (t_position_assignmentsTableAdapter),
                typeof (t_position_evaluation_formsTableAdapter),
                typeof (t_position_salary_itemsTableAdapter),
                typeof(t_repository_assignmentTableAdapter),
                typeof(t_repository_evaluationTableAdapter),
                typeof(t_repository_salary_structTableAdapter),
                typeof(t_salary_data_source_typeTableAdapter),
                typeof (t_salary_itemTableAdapter),
                typeof (t_salary_item_typeTableAdapter),
                typeof (t_settingsTableAdapter),
                typeof(t_unitTableAdapter),
                typeof(v_assignment_detailTableAdapter),
                typeof(v_evaluation_form_detailTableAdapter),
                typeof(v_salary_struct_detailTableAdapter)
            });
        }

        public static void InitAdapter()
        {
            _adapterTypes.ForEach(type =>
            {
                string propertyName = type.Name;
                PropertyInfo[] propertyInfos = typeof (TableAdapterManager).GetProperties(BindingFlags.Public|BindingFlags.SetProperty|BindingFlags.Instance);
                var item = propertyInfos.FirstOrDefault(field => field.Name == propertyName);
                if (item == null) return;
                var instance = Activator.CreateInstance(type);
                item.SetValue(_adapterManager, instance, null);
            });
        }

        public static TableAdapterManager AdapterManager
        {
            get { return _adapterManager; }
        }

        public static DataSetSalary DataSet
        {
            get { return _dataSet; }
        }

        #region 数据表

        public static DataSetSalary.t_assignment_itemDataTable AssignmentItem
        {
            get { return _dataSet.t_assignment_item; }
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

        public static DataSetSalary.v_assignment_detailDataTable AssignmentDetail
        {
            get { return _dataSet.v_assignment_detail; }
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

        #region Adapters

        public static t_assignment_itemTableAdapter AssignmentItemTableAdapter
        {
            get { return _adapterManager.t_assignment_itemTableAdapter; }
        }

        public static t_assignment_item_typeTableAdapter AssignmentItemTypeTableAdapter
        {
            get { return _adapterManager.t_assignment_item_typeTableAdapter; }
        }
        public static t_assignment_performanceTableAdapter AssignmentPerformanceTableAdapter
        {
            get { return _adapterManager.t_assignment_performanceTableAdapter; }
        }

        public static t_employeeTableAdapter EmployeeTableAdapter
        {
            get { return _adapterManager.t_employeeTableAdapter; }
        }

        public static t_employee_salary_detailTableAdapter EmployeeSalaryDetailTableAdapter
        {
            get { return _adapterManager.t_employee_salary_detailTableAdapter; }
        }

        public static t_evaluation_formTableAdapter EvaluationFormTableAdapter
        {
            get { return _adapterManager.t_evaluation_formTableAdapter; }
        }

        public static t_evaluation_form_itemsTableAdapter EvaluationFormItemsTableAdapter
        {
            get { return _adapterManager.t_evaluation_form_itemsTableAdapter; }
        }

        public static t_evaluation_itemTableAdapter EvaluationItemTableAdapter
        {
            get { return _adapterManager.t_evaluation_itemTableAdapter; }
        }

        public static t_evaluation_item_typeTableAdapter EvaluationItemTypeTableAdapter
        {
            get { return _adapterManager.t_evaluation_item_typeTableAdapter; }
        }

        public static t_evaluation_resultsTableAdapter EvaluationResultsTableAdapter
        {
            get { return _adapterManager.t_evaluation_resultsTableAdapter; }
        }

        public static t_evaluation_standardTableAdapter EvaluationStandardTableAdapter
        {
            get { return _adapterManager.t_evaluation_standardTableAdapter; }
        }

        public static t_positionTableAdapter PositionTableAdapter
        {
            get { return _adapterManager.t_positionTableAdapter; }
        }

        public static t_position_assignmentsTableAdapter PositionAssignmentsTableAdapter
        {
            get { return _adapterManager.t_position_assignmentsTableAdapter; }
        }

        public static t_position_evaluation_formsTableAdapter PositionEvaluationFormsTableAdapter
        {
            get { return _adapterManager.t_position_evaluation_formsTableAdapter; }
        }

        public static t_position_salary_itemsTableAdapter PositionSalaryItemsTableAdapter
        {
            get { return _adapterManager.t_position_salary_itemsTableAdapter; }
        }

        public static t_repository_assignmentTableAdapter RepositoryAssignmentTableAdapter
        {
            get { return _adapterManager.t_repository_assignmentTableAdapter; }
        }

        public static t_repository_evaluationTableAdapter RepositoryEvaluationTableAdapter
        {
            get { return _adapterManager.t_repository_evaluationTableAdapter; }
        }

        public static t_repository_salary_structTableAdapter RepositorySalaryStructTableAdapter
        {
            get { return _adapterManager.t_repository_salary_structTableAdapter; }
        }

        public static t_salary_data_source_typeTableAdapter SalaryDataSourceTypeTableAdapter
        {
            get { return _adapterManager.t_salary_data_source_typeTableAdapter; }
        }
        public static t_salary_itemTableAdapter SalaryItemTableAdapter
        {
            get { return _adapterManager.t_salary_itemTableAdapter; }
        }

        public static t_salary_item_typeTableAdapter SalaryItemTypeTableAdapter
        {
            get { return _adapterManager.t_salary_item_typeTableAdapter; }
        }

        public static t_settingsTableAdapter SettingsTableAdapter
        {
            get { return _adapterManager.t_settingsTableAdapter; }
        }

        public static t_unitTableAdapter UnitTableAdapter
        {
            get { return _adapterManager.t_unitTableAdapter; }
        }

        private static readonly v_assignment_detailTableAdapter _assignmentDetailTableAdapter=new v_assignment_detailTableAdapter();

        public static v_assignment_detailTableAdapter AssignmentDetailTableAdapter
        {
            get { return _assignmentDetailTableAdapter; }
        }

        private static readonly v_evaluation_form_detailTableAdapter _evaluationFormDetailTableAdapter=new v_evaluation_form_detailTableAdapter();
        public static v_evaluation_form_detailTableAdapter EvaluationFormDetailTableAdapter
        {
            get { return _evaluationFormDetailTableAdapter; }
        }
        static readonly v_salary_struct_detailTableAdapter _salaryStructDetailTableAdapter=new v_salary_struct_detailTableAdapter();

        public static v_salary_struct_detailTableAdapter SalaryStructDetailTableAdapter
        {
            get { return _salaryStructDetailTableAdapter; }
        }

        #endregion
    }
}