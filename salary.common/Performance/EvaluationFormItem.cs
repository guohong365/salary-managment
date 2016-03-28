namespace SalarySystem.Performance
{
    public class EvaluationFormItem : EvaluationElementBase, IEvaluationFormItem
    {
        public EvaluationFormItem(string id, string name, string detail, decimal fullMark)
            :base(id, name, detail, fullMark)
        {
        }
    }
}