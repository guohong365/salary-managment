using SalarySystem.Data;

namespace SalarySystem
{
    public static class GlobalSettings
    {
        public const int TYPE_USER_SETTING = 1;
        public const int TYPE_SYSTEM_SETTING = 0;
        public const string TYPE_SALARY_DATA_SOURCE_INLINE = "1";
        public const string TYPE_SALARY_DATA_SROUCE_FORMULA = "2";

        public const string TYPE_ASSIGNMENT_AUTO_ASSIGN = "1";
        public const string TYPE_ASSIGNMENT_FIX_AMOUNT = "2";
        public const string TYPE_ASSIGNMENT_UNLIMIT = "3";

        public const string GENERAL_POSITION = "9999999999";
        public const string KEY_EVALUATION_VERSION = "repository.evaluation";
        public const string KEY_SALARY_VERSION = "repository.salary";
        public const string KEY_ASSIGNMENT_VERSION = "repository.assignment";

        public static DataSetSalary.t_repository_evaluationRow
            CurrentEvaluationRepository;

        public static DataSetSalary.t_repository_salary_structRow CurrentSalaryRepository;
        public static DataSetSalary.t_repository_assignmentRow CurrentAssignmentRepository;

        public static string EvaluationFullVersion
        {
            get { return string.Format("{0}-{1}", CurrentEvaluationRepository.NAME, CurrentEvaluationRepository.ID); }
        }

        public static string EvaluationVersion
        {
            get { return CurrentEvaluationRepository.ID; }
        }

        public static string AssignmentFullVersion
        {
            get { return string.Format("{0}-{1}", CurrentAssignmentRepository.NAME, CurrentAssignmentRepository.ID); }
        }
        public static string AssignmentVersion
        {
            get { return CurrentAssignmentRepository.ID; }
        }
        public static string SalaryFullVersion
        {
            get { return string.Format("{0}-{1}", CurrentSalaryRepository.NAME, CurrentSalaryRepository.ID); }
        }
        public static string SalaryVersion
        {
            get { return CurrentSalaryRepository.ID; }
        }
    }
}
