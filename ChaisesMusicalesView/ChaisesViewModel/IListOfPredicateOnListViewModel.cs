using System.Collections.Generic;

namespace ChaisesMusicales
{
    public interface IListOfPredicateOnListViewModel<T>
    {
        List<T> getListPredicates();
    }
}