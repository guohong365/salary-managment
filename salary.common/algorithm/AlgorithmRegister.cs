namespace SalarySystem.Algorithm
{
    class AlgorithmRegister
    {
        protected static AlgorithmRegister Register=new AlgorithmRegister();
        private AlgorithmRegister()
        {
            AlgorithmManager.Register(typeof(AddAlgorithm));
        }
    }
}
