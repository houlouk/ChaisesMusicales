using System.Collections.Generic;

namespace ChaisesMusicales
{
    internal interface IListRandomizer<T>
    {
        List<T> randomizeList(List<IPredicateOnList<T>> list);
    }
}