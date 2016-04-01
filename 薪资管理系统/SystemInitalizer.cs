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
            
            DataHolder.EvaluationRepositoryTableAdapter.Fill(DataHolder.EvaluationRepositry);
            DataHolder.SalaryRepositoryTableAdapter.Fill(DataHolder.SalaryRepository);
            #region 加载当前考核版本
            var settingRow = DataHolder.Settings.FindByNAME(GlobalSettings.KeyEvaluationVersion);
            if (settingRow != null)
            {
                GlobalSettings.CurrentEvaluationRepository = DataHolder.EvaluationRepositry.FindByID(settingRow.VALUE);
            }
            else
            {
                settingRow = DataHolder.Settings.Newt_settingsRow();
                settingRow.NAME = GlobalSettings.KeyEvaluationVersion;
                settingRow.TYPE = GlobalSettings.TypeSystemSetting;
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
            settingRow = DataHolder.Settings.FindByNAME(GlobalSettings.KeySalaryVersion);
            if (settingRow != null)
            {
                GlobalSettings.CurrentSalaryRepository = DataHolder.SalaryRepository.FindByID(settingRow.VALUE);
            }
            else
            {
                settingRow = DataHolder.Settings.Newt_settingsRow();
                settingRow.NAME = GlobalSettings.KeySalaryVersion;
                settingRow.TYPE = GlobalSettings.TypeSystemSetting;
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
            #endregion

            return true;
        }

        private static bool createNewSalaryVersion(DataSetSalary.t_settingsRow settingRow)
        {
            var newRow = DataHolder.SalaryRepository.Newt_salary_repositoryRow();
            var form = new ItemEditForm(ItemControl.GetFactory(), "新建薪资结构版本", newRow, (int) EditPurpose.FOR_NEW);
            if(form.ShowDialog()!=DialogResult.OK) return false;
            newRow = form.Row as DataSetSalary.t_salary_repositoryRow;
            Debug.Assert(newRow != null, "newRow != null");
            newRow.CREATE_TIME = DateTime.Now;
            newRow.CREATOR = "未知";
            newRow.ENABLED = true;
            DataHolder.SalaryRepository.Addt_salary_repositoryRow(newRow);
            settingRow.VALUE = newRow.ID;
            DataHolder.SalaryRepositoryTableAdapter.Update(newRow);
            return true;
        }

        private static bool createNewEvaluationVersion(DataSetSalary.t_settingsRow row)
        {
            var newRow= DataHolder.EvaluationRepositry.Newt_evaluation_repositoryRow();
            var form = new ItemEditForm(ItemControl.GetFactory(), "新建绩效考核版本", newRow, (int)EditPurpose.FOR_NEW);
            
            if (form.ShowDialog() != DialogResult.OK) return false;
            newRow = form.Row as DataSetSalary.t_evaluation_repositoryRow;
            Debug.Assert(newRow != null, "newRow != null");
            newRow.CREATE_TIME = DateTime.Now;
            newRow.SetCREATORNull();
            newRow.ENABLED = true;
            DataHolder.EvaluationRepositry.Addt_evaluation_repositoryRow(newRow);
            row.VALUE = newRow.ID;
            DataHolder.EvaluationRepositoryTableAdapter.Update(newRow);
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
            DataHolder.EvaluationStandardTableAdapter.Fill(DataHolder.EvaluationStandard);
            DataHolder.PositionEvaluationFormsTableAdapter.Fill(DataHolder.PositionEvaluationForms);
            
            #endregion

            #region 任务相关

            DataHolder.AssignmentTableAdapter.Fill(DataHolder.Assignment);
            DataHolder.PositionAssignmentsTableAdapter.Fill(DataHolder.PositionAssignments);

            #endregion
            #region 薪资相关

            DataHolder.SalaryItemTableAdapter.Fill(DataHolder.SalaryItem);
            DataHolder.SalaryItemTypeTableAdapter.Fill(DataHolder.SalaryItemType);
            DataHolder.PositionSalaryItemsTableAdapter.Fill(DataHolder.PositionSalaryItems);
            
            #endregion
        }
    }
}
