using System.Collections.Generic;

namespace ChaisesMusicales
{
    public interface IListOfPredicateOnListViewModel<T>
    {
        List<IPredicateOnList<T>> getListPredicates();
    }
}