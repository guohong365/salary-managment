namespace SalarySystem
{
    public interface ITypeConverter<T>
    {
        T FromString(string strVal);
        T FromObject(object objVal);
    }

    public interface ITypeConverter
    {
        object FromString(string strVal);
        string ToString(object strVal);
    }
}