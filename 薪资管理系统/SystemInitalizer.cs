using System;
using System.Diagnostics;
using System.Windows.Forms;
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
            DataHolder.SettingsTableAdapter.Fill(DataHolder.Settings);
            
            DataHolder.RepositoryEvaluationTableAdapter.Fill(DataHolder.RepositoryEvaluation);
            DataHolder.RepositoryAssignmentTableAdapter.Fill(DataHolder.RepositoryAssignment);
            DataHolder.RepositorySalaryStructTableAdapter.Fill(DataHolder.RepositorySalaryStruct);
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
                DataHolder.SettingsTableAdapter.Update(settingRow);
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
                DataHolder.SettingsTableAdapter.Update(settingRow);
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
                DataHolder.SettingsTableAdapter.Update(settingRow);
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
            DataHolder.RepositoryAssignmentTableAdapter.Update(newRow);
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
            DataHolder.RepositorySalaryStructTableAdapter.Update(newRow);
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
            DataHolder.RepositoryEvaluationTableAdapter.Update(newRow);
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

            DataHolder.EmployeeTableAdapter.Fill(DataHolder.Employee);
            DataHolder.PositionTableAdapter.Fill(DataHolder.Position);
            
            #endregion

            #region 绩效相关

            
            DataHolder.EvaluationFormTableAdapter.Fill(DataHolder.EvaluationForm);
            DataHolder.EvaluationFormItemsTableAdapter.Fill(DataHolder.EvaluationFormItems);
            DataHolder.EvaluationItemTableAdapter.Fill(DataHolder.EvaluationItem);
            DataHolder.EvaluationItemTypeTableAdapter.Fill(DataHolder.EvaluationItemType);
            DataHolder.EvaluationStandardTableAdapter.Fill(DataHolder.EvaluationStandard);
            DataHolder.PositionEvaluationFormsTableAdapter.Fill(DataHolder.PositionEvaluationForms);

            DataHolder.EvaluationFormDetailTableAdapter.Fill(DataHolder.EvaluationFormDetail);
            #endregion

            #region 任务相关

            DataHolder.AssignmentItemTableAdapter.Fill(DataHolder.AssignmentItem);
            DataHolder.AssignmentItemTypeTableAdapter.Fill(DataHolder.AssignmentItemType);
            DataHolder.PositionAssignmentsTableAdapter.Fill(DataHolder.PositionAssignments);
            DataHolder.AssignmentDetailTableAdapter.Fill(DataHolder.AssignmentDetail);
            DataHolder.UnitTableAdapter.Fill(DataHolder.Unit);
            #endregion
            #region 薪资相关

            DataHolder.SalaryDataSourceTypeTableAdapter.Fill(DataHolder.SalaryDataSourceType);
            DataHolder.SalaryItemTableAdapter.Fill(DataHolder.SalaryItem);
            DataHolder.SalaryItemTypeTableAdapter.Fill(DataHolder.SalaryItemType);
            DataHolder.PositionSalaryItemsTableAdapter.Fill(DataHolder.PositionSalaryItems);

            DataHolder.SalaryStructDetailTableAdapter.Fill(DataHolder.SalaryStructDetail);

            #endregion
        }
    }
}
