using System.Collections.Generic;

namespace ChaisesMusicales
{
    public interface IPredicateManager<T>
    {
        List<T> getListPredicates();

    }
}