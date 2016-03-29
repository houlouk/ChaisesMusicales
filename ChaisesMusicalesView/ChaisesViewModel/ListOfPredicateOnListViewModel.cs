using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    class ListOfPredicateOnListViewModel<T>
    {
        private ObservableCollection<PredicateOnListViewModel<T>> predicatesOnListViewModel = new ObservableCollection<PredicateOnListViewModel<T>>();

        public ObservableCollection<PredicateOnListViewModel<T>> PredicatesOnListViewModel
        {
            get { return this.predicatesOnListViewModel; }
            set { this.predicatesOnListViewModel = value; }
        }
        public ListOfPredicateOnListViewModel()
        {
            
            List<IPredicateOnList<predicate>> predicateList = PredicateManager.getListPredicates();
            foreach (PredicateOnList<T> p in predicateList)
            {
                PredicatesOnListViewModel.Add(new PredicateOnListViewModel<T>(p));
            }
        }

        internal List<IPredicateOnList<T>> getListPredicates()
        {
            List<IPredicateOnList<T>> predicates = new List<IPredicateOnList<T>>();
            foreach (PredicateOnListViewModel<T> pvm in predicatesOnListViewModel)
            {
                predicates.Add(pvm.Predicate);

            }
            return predicates;
        }
    }
}
