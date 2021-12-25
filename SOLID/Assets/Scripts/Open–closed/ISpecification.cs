namespace Open_closed
{
    public interface ISpecification<in T>
    {
        bool IsClassified(T item);
    }
}
