using MicroMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    class PredicateOnListViewModel:ObservableObject

    {
        private PredicateOnList<int> predicate;
        public PredicateOnListViewModel(PredicateOnList<int> predicate)
        {
            this.predicate = predicate;
        }

        public PredicateOnList<int> Predicate
        {
            get
            {
                return this.predicate;
            }

            set
            {
                this.predicate = value;
            }
        }

        public predicate PredicateFunc
        {
            get { return Predicate.RealPredicate; }
            set
            {
                Predicate.RealPredicate = value;
                RaisePropertyChanged("RealPredicateFunc");
            }
        }
    }
}

