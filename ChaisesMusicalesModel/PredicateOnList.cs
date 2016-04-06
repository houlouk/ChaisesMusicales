using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    

    public class PredicateOnList<T>:IPredicateOnList<T>
    {
        private T realPredicate;

        public PredicateOnList(T realPredicate)
        {
            this.realPredicate = realPredicate;
        }

        public T RealPredicate
        {
            get
            {
                return realPredicate;
            }

            set
            {
                realPredicate = value;
            }
        }
    }
}
