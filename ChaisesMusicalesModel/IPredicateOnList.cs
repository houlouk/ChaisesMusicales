

using System;
using System.Collections.Generic;

namespace ChaisesMusicales
{
    public interface IPredicateOnList<T>
    {
        T RealPredicate
        {
            get;


            set;
        
        }
    }
}