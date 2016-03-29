using MicroMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    class PredicateOnListViewModel<T>:ObservableObject

    {
        private PredicateOnList<T> predicate;
        public PredicateOnListViewModel(PredicateOnList<T> predicate)
        {
            this.predicate = predicate;
        }

        public PredicateOnList<T> Predicate
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

        public T PredicateFunc
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

