using System;
using System.Collections.Generic;

namespace ChaisesMusicales
{
    internal class PredicateFactory<T,U> 
    {
        internal static IPredicateManager<T> create(Type type)
        {
            if (type.Equals(typeof(Predicate<List<int>>))) return (IPredicateManager<T>)(new PredicateManager());

            throw new Exception("cast non valide");
        }

        internal static IListRandomizer<U, T> createIRandomizer(Type type)
        {
            return (IListRandomizer<U, T>) (new IntListRandomizer<U>());     
                }
    }
}