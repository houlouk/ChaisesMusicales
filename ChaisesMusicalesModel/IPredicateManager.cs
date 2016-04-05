using System.Collections.Generic;

namespace ChaisesMusicales
{
    public interface IPredicateManager<T>
    {
        List<IPredicateOnList<T>> getListPredicates();

    }
}