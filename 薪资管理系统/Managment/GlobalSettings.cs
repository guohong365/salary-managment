using SalarySystem.Data;

namespace SalarySystem.Managment
{
    public static class GlobalSettings
    {
        public static int TypeUserSetting = 1;
        public static int TypeSystemSetting = 0;

        public static string KeyEvaluationVersion = "repository.evaluation";
        public static string KeySalaryVersion = "repository.salary";
        public static string KeyAssignmentVersion = "repository.assignment";

        public static DataSetSalary.t_evaluation_repositoryRow
            CurrentEvaluationRepository;
        public static DataSetSalary.t_salary_repositoryRow CurrentSalaryRepository;

        public static void Load()
        {
            
        }
    }
}
