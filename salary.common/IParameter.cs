namespace salary
{
    public interface IParameter : IItem
    {
        object Value { get; set; }
    }

    public interface IParameter<T>
    {
        T Value { get; set; }
    }
}
