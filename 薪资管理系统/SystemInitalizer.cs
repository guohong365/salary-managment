using System;
using System.Diagnostics;
using System.Windows.Forms;
using SalarySystem.Data;
using SalarySystem.Managment.Editor;
using UC.Platform.Data;

namespace SalarySystem
{
    public static class SystemInitalizer
    {
        private static bool loadSettings()
        {
            initDatabase();
            DBHandlerEx.FillOnce(DataHolder.Settings, "select * from t_settings");
            DBHandlerEx.FillOnce(DataHolder.RepositoryEvaluation, "select * from t_repository_evaluation");
            DBHandlerEx.FillOnce(DataHolder.RepositoryAssignment, "select * from t_repository_assignment");
            DBHandlerEx.FillOnce(DataHolder.RepositorySalaryStruct, "select * from t_repository_salary_struct");
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
                DBHandlerEx.UpdateOnce(settingRow);
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
                DBHandlerEx.UpdateOnce(settingRow);
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
                DBHandlerEx.UpdateOnce(settingRow);
            }
            #endregion

            _sqlLoadEvaluationForm = string.Format("select * from t_evaluation_form where VERSION_ID='{0}'", GlobalSettings.EvaluationVersion);
            _sqlLoadEvaluationFormItems = string.Format("select * from t_evaluation_form_items where VERSION_ID='{0}'", GlobalSettings.EvaluationVersion);
            _sqlLoadEvaluationItem = string.Format("select * from t_evaluation_item where VERSION_ID='{0}'",
                GlobalSettings.EvaluationVersion);
            _sqlLoadEvaluationItemType = "select * from t_evaluation_item_type";
            _sqlLoadPositionEvaluationForms =
                string.Format("select * from t_position_evaluation_forms where VERSION_ID='{0}'",
                    GlobalSettings.EvaluationVersion);
            _sqlLoadEvaluationFormDetail = string.Format(
                "select * from v_evaluation_form_detail where VERSION_ID='{0}'", GlobalSettings.EvaluationVersion);
            _sqlLoadEvaluationStandard = "select * from t_evaluation_standard";

            _sqlLoadAssignmentDefine = string.Format("select * from t_assignment_define where VERSION_ID='{0}'",
                GlobalSettings.AssignmentVersion);
            _sqlLoadPositionAssignments = string.Format("select * from t_position_assignments where VERSION_ID='{0}'",
                GlobalSettings.AssignmentVersion);
            _sqlLoadAssignmentItemType = "select * from t_assignment_item_type";
            _sqlLoadAssignmentUnit = "select * from t_unit";
            return true;
        }

        private static void initDatabase()
        {
            DBHandlerEx.RegisterDBDefaultType("MySql.Data.MySqlClient", "server=localhost;user id=root;persistsecurityinfo=True;database=salary;password=1111");
            //DBHandlerEx.RegisterDBDefaultType(ConfigurationManager.ConnectionStrings[0]);
        }

        private static string _sqlLoadEvaluationForm;
        private static string _sqlLoadEvaluationFormItems;
        private static string _sqlLoadEvaluationItem;
        private static string _sqlLoadEvaluationItemType;
        private static string _sqlLoadPositionEvaluationForms;
        private static string _sqlLoadEvaluationFormDetail;
        private static string _sqlLoadEvaluationStandard;
        private static string _sqlLoadAssignmentDefine;
        private static string _sqlLoadPositionAssignments;
        private static string _sqlLoadAssignmentItemType;
        private static string _sqlLoadAssignmentUnit;

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
            DBHandlerEx.UpdateOnce(newRow);
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
            DBHandlerEx.UpdateOnce(newRow);
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
            DBHandlerEx.UpdateOnce(newRow);
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

            DBHandlerEx.FillOnce(DataHolder.Employee, "select * from t_employee");
            DBHandlerEx.FillOnce(DataHolder.Position, "select * from t_position");
           
            #endregion

            #region 绩效相关
            
            DBHandlerEx.FillOnce(DataHolder.EvaluationForm, _sqlLoadEvaluationForm);
            DBHandlerEx.FillOnce(DataHolder.EvaluationFormItems, _sqlLoadEvaluationFormItems);

            DBHandlerEx.FillOnce(DataHolder.EvaluationItem, _sqlLoadEvaluationItem);
            DBHandlerEx.FillOnce(DataHolder.EvaluationItemType, _sqlLoadEvaluationItemType);
            DBHandlerEx.FillOnce(DataHolder.PositionEvaluationForms, _sqlLoadPositionEvaluationForms);
            DBHandlerEx.FillOnce(DataHolder.EvaluationFormDetail, _sqlLoadEvaluationFormDetail);
            DBHandlerEx.FillOnce(DataHolder.EvaluationStandard, _sqlLoadEvaluationStandard);
            #endregion

            #region 任务相关

            DBHandlerEx.FillOnce(DataHolder.AssignmentDefine, _sqlLoadAssignmentDefine);
            DBHandlerEx.FillOnce(DataHolder.AssignmentItemType, _sqlLoadAssignmentItemType);
            DBHandlerEx.FillOnce(DataHolder.PositionAssignments, _sqlLoadPositionAssignments);
            DBHandlerEx.FillOnce(DataHolder.Unit, _sqlLoadAssignmentUnit);
            #endregion
            #region 薪资相关

            DBHandlerEx.FillOnce(DataHolder.SalaryDataSourceType, "select * from t_salary_data_source_type");
            DBHandlerEx.FillOnce(DataHolder.SalaryItem, "select * from t_salary_item");
            DBHandlerEx.FillOnce(DataHolder.SalaryItemType, "select * from t_salary_item_type");
            DBHandlerEx.FillOnce(DataHolder.PositionSalaryItems, "select * from t_position_salary_items");

            DBHandlerEx.FillOnce(DataHolder.SalaryStructDetail, "select * from v_salary_struct_detail");

            #endregion
        }
    }
}
