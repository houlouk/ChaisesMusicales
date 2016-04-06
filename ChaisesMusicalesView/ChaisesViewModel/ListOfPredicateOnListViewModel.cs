using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    class ListOfPredicateOnListViewModel<T,U>:IListOfPredicateOnListViewModel<T>
    {
        private ObservableCollection<PredicateOnListViewModel<T>> predicatesOnListViewModel = new ObservableCollection<PredicateOnListViewModel<T>>();
           
        public ObservableCollection<PredicateOnListViewModel<T>> PredicatesOnListViewModel
        {
            get { return this.predicatesOnListViewModel; }
            set { this.predicatesOnListViewModel = value; }
        }
        public ListOfPredicateOnListViewModel()
        {
            IPredicateManager<T> predicateManager = PredicateFactory<T,U>.create(typeof(T));
            List<T> predicateList = predicateManager.getListPredicates();
            foreach (T p in predicateList)
            {
                PredicatesOnListViewModel.Add(new PredicateOnListViewModel<T>(p));
            }
        }

        public List<T> getListPredicates()
        {
            List<T> predicates = new List<T>();
            foreach (PredicateOnListViewModel<T> pvm in predicatesOnListViewModel)
            {
                predicates.Add(pvm.Predicate);

            }
            return predicates;
        }

        public void removePredicate(PredicateOnListViewModel<T> pred)
        {
            predicatesOnListViewModel.Remove(pred);
        }
    }
}
