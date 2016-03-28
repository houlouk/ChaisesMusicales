using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    public delegate bool predicate(IList<int> predicate);
    public class PredicateOnList<T>:IPredicateOnList<T>
    {
        private predicate realPredicate;

        public PredicateOnList(predicate realPredicate)
        {
            this.realPredicate = realPredicate;
        }

        public predicate RealPredicate
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
