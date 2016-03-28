namespace SalarySystem.Core
{
    public interface ICopyable
    {
        object CopyFrom(object another);
    }

    public interface ICopyable<T>
    {
        T CopyFrom(T anther);
    }
}
