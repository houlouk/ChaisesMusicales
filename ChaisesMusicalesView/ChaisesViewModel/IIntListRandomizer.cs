using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChaisesMusicales
{
    internal interface IListRandomizer<T,U>
    {
        List<T> mixNFirstIntegers(ObservableCollection<T> list ,List<IPredicateOnList<U>> predicats);
    }
}