using System.Collections.Generic;

namespace Open_closed
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> objects, ISpecification<T> specification);
    }
}