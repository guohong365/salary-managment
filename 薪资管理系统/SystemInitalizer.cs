using System;
using System.Diagnostics;
using System.Windows.Forms;
using Platform.DBHelper;
using SalarySystem.Data;
using SalarySystem.Managment;
using SalarySystem.Managment.Editor;

namespace SalarySystem
{
    public static class SystemInitalizer
    {
        private static bool loadSettings()
        {
            DataHolder.InitAdapter();
            DBHandler.FillOnce(DataHolder.Settings, "select * from t_settings");
            DBHandler.FillOnce(DataHolder.RepositoryEvaluation, "select * from t_repository_evaluation");
            DBHandler.FillOnce(DataHolder.RepositoryAssignment, "select * from t_repository_assignment");
            DBHandler.FillOnce(DataHolder.RepositorySalaryStruct, "select * from t_repository_salary_struct");
            #region 加载当前考核版本
            var settingRow = DataHolder.Settings.FindByNAME(GlobalSettings.KEY_EVALUATION_VERSION);
            if (settingRow != null)
            {
                GlobalSettings.CurrentEvaluationRepository = DataHolder.RepositoryEvaluation.FindByID(settingRow.VALUE);
            }
            else
            {
                settingRow = DataHolder.Settings.Newt_settingsRow();
                settingRow.NAME = GlobalSettings.KEY_EVALUATION_VERSION;
                settingRow.TYPE = GlobalSettings.TYPE_SYSTEM_SETTING;
                settingRow.DESCRIPTION = "当前绩效考核版本";
                settingRow.VALUE = "new";
                DataHolder.Settings.Addt_settingsRow(settingRow);
            }
            if(GlobalSettings.CurrentEvaluationRepository==null)
            {
                if (!createNewEvaluationVersion(settingRow))
                {
                    DataHolder.Settings.RejectChanges();
                    return false;
                }
                DBHandler.UpdateOnce(settingRow);
            }
            #endregion
            #region 加载当前工资结构版本
            settingRow = DataHolder.Settings.FindByNAME(GlobalSettings.KEY_SALARY_VERSION);
            if (settingRow != null)
            {
                GlobalSettings.CurrentSalaryRepository = DataHolder.RepositorySalaryStruct.FindByID(settingRow.VALUE);
            }
            else
            {
                settingRow = DataHolder.Settings.Newt_settingsRow();
                settingRow.NAME = GlobalSettings.KEY_SALARY_VERSION;
                settingRow.TYPE = GlobalSettings.TYPE_SYSTEM_SETTING;
                settingRow.DESCRIPTION = "当前薪资构成版本";
                settingRow.VALUE = "new";
                DataHolder.Settings.Addt_settingsRow(settingRow);
            }
            if (GlobalSettings.CurrentSalaryRepository == null)
            {
                if (!createNewSalaryVersion(settingRow))
                {
                    DataHolder.Settings.RejectChanges();
                    return false;
                }
                DBHandler.UpdateOnce(settingRow);
            }
            #endregion
            #region 加载当前任务版本

            settingRow = DataHolder.Settings.FindByNAME(GlobalSettings.KEY_ASSIGNMENT_VERSION);
            if (settingRow != null)
            {
                GlobalSettings.CurrentAssignmentRepository = DataHolder.RepositoryAssignment.FindByID(settingRow.VALUE);
            }
            else
            {
                settingRow = DataHolder.Settings.Newt_settingsRow();
                settingRow.NAME = GlobalSettings.KEY_ASSIGNMENT_VERSION;
                settingRow.TYPE = GlobalSettings.TYPE_SYSTEM_SETTING;
                settingRow.DESCRIPTION = "当前任务指标版本";
                settingRow.VALUE = "new";
                DataHolder.Settings.Addt_settingsRow(settingRow);
            }
            if (GlobalSettings.CurrentAssignmentRepository == null)
            {
                if (!createNewAssignmentVersion(settingRow))
                {
                    DataHolder.Settings.RejectChanges();
                    return false;
                }
                DBHandler.UpdateOnce(settingRow);
            }
            #endregion

            return true;
        }

        private static bool createNewAssignmentVersion(DataSetSalary.t_settingsRow settingRow)
        {
            var newRow = DataHolder.RepositoryAssignment.Newt_repository_assignmentRow();
            var form = new ItemEditForm(ItemControl.GetFactory(), "新建任务指标版本", newRow, (int)EditPurpose.FOR_NEW);
            if (form.ShowDialog() != DialogResult.OK) return false;
            newRow = form.Row as DataSetSalary.t_repository_assignmentRow;
            Debug.Assert(newRow != null, "newRow != null");
            newRow.CREATE_TIME = DateTime.Now;
            newRow.CREATOR = "nobody";
            newRow.ENABLED = true;
            DataHolder.RepositoryAssignment.Addt_repository_assignmentRow(newRow);
            settingRow.VALUE = newRow.ID;
            DBHandler.UpdateOnce(newRow);
            return true;
        }

        private static bool createNewSalaryVersion(DataSetSalary.t_settingsRow settingRow)
        {
            var newRow = DataHolder.RepositorySalaryStruct.Newt_repository_salary_structRow();
            var form = new ItemEditForm(ItemControl.GetFactory(), "新建薪资结构版本", newRow, (int) EditPurpose.FOR_NEW);
            if(form.ShowDialog()!=DialogResult.OK) return false;
            newRow = form.Row as DataSetSalary.t_repository_salary_structRow;
            Debug.Assert(newRow != null, "newRow != null");
            newRow.CREATE_TIME = DateTime.Now;
            newRow.CREATOR = "nobody";
            newRow.ENABLED = true;
            DataHolder.RepositorySalaryStruct.Addt_repository_salary_structRow(newRow);
            settingRow.VALUE = newRow.ID;
            DBHandler.UpdateOnce(newRow);
            return true;
        }

        private static bool createNewEvaluationVersion(DataSetSalary.t_settingsRow row)
        {
            var newRow = DataHolder.RepositoryEvaluation.Newt_repository_evaluationRow();
            var form = new ItemEditForm(ItemControl.GetFactory(), "新建绩效考核版本", newRow, (int)EditPurpose.FOR_NEW);
            
            if (form.ShowDialog() != DialogResult.OK) return false;
            newRow = form.Row as DataSetSalary.t_repository_evaluationRow;
            Debug.Assert(newRow != null, "newRow != null");
            newRow.CREATE_TIME = DateTime.Now;
            newRow.CREATOR="nobody";
            newRow.ENABLED = true;
            DataHolder.RepositoryEvaluation.Addt_repository_evaluationRow(newRow);
            row.VALUE = newRow.ID;
            DBHandler.UpdateOnce(newRow);
            return true;
        }

        public static bool Init()
        {
            if(!loadSettings()) return false;
            loadDefines();
            return true;
        }

        private static void loadDefines()
        {
            #region 基本

            DBHandler.FillOnce(DataHolder.Employee, "select * from t_employee");
            DBHandler.FillOnce(DataHolder.Position, "select * from t_position");
            //DataHolder.EmployeeTableAdapter.Fill(DataHolder.Employee);
            //DataHolder.PositionTableAdapter.Fill(DataHolder.Position);
            
            #endregion

            #region 绩效相关

            DBHandler.FillOnce(DataHolder.EvaluationForm, "select * from t_evaluation_form");
            DBHandler.FillOnce(DataHolder.EvaluationFormItems, "select * from t_evaluation_form_items");
            DBHandler.FillOnce(DataHolder.EvaluationItem, "select * from t_evaluation_item");
            DBHandler.FillOnce(DataHolder.EvaluationItemType, "select * from t_evaluation_item_type");
            DBHandler.FillOnce(DataHolder.PositionEvaluationForms, "select * from t_position_evaluation_forms");
            DBHandler.FillOnce(DataHolder.EvaluationFormDetail, "select * from v_evaluation_form_detail");
            DBHandler.FillOnce(DataHolder.EvaluationStandard, "select * from t_evaluation_standard");
            #endregion

            #region 任务相关

            DBHandler.FillOnce(DataHolder.AssignmentItem, "select * from t_assignment_item");
            DBHandler.FillOnce(DataHolder.AssignmentItemType, "select * from t_assignment_item_type");
            DBHandler.FillOnce(DataHolder.PositionAssignments, "select * from t_position_assignments");
            DBHandler.FillOnce(DataHolder.AssignmentDetail,"select * from v_assignment_detail");
            DBHandler.FillOnce(DataHolder.Unit, "select * from t_unit");
            #endregion
            #region 薪资相关

            DBHandler.FillOnce(DataHolder.SalaryDataSourceType, "select * from t_salary_data_source_type");
            DBHandler.FillOnce(DataHolder.SalaryItem, "select * from t_salary_item");
            DBHandler.FillOnce(DataHolder.SalaryItemType, "select * from t_salary_item_type");
            DBHandler.FillOnce(DataHolder.PositionSalaryItems, "select * from t_position_salary_items");

            DBHandler.FillOnce(DataHolder.SalaryStructDetail, "select * from v_salary_struct_detail");

            #endregion
        }
    }
}
