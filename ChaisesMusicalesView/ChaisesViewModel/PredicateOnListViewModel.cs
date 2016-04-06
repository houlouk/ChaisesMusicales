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
        private T predicate;
        public PredicateOnListViewModel(T predicate)
        {
            this.predicate = predicate;
        }

        public T Predicate
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
            get { return predicate; }
            set
            {
                predicate = value;
                RaisePropertyChanged("RealPredicateFunc");
            }
        }
    }
}

