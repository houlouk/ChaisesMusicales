using System;

namespace ChaisesMusicales
{
    internal class PredicateFactory<T>
    {
        internal static IPredicateManager<T> create(Type type)
        {
            if (type.Equals(typeof(predicate))) return (IPredicateManager<T>)(new PredicateManager());

            throw new Exception("cast non valide");
        }

        internal static IListRandomizer<IChaiseViewModel, T> createIRandomizer(Type type)
        {
            return (IListRandomizer<IChaiseViewModel, T>) (new IntListRandomizer<IChaiseViewModel>());     
                }
    }
}