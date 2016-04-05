using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    class ListOfPredicateOnListViewModel<T>:IListOfPredicateOnListViewModel<T>
    {
        private ObservableCollection<PredicateOnListViewModel<T>> predicatesOnListViewModel = new ObservableCollection<PredicateOnListViewModel<T>>();
           
        public ObservableCollection<PredicateOnListViewModel<T>> PredicatesOnListViewModel
        {
            get { return this.predicatesOnListViewModel; }
            set { this.predicatesOnListViewModel = value; }
        }
        public ListOfPredicateOnListViewModel()
        {
            IPredicateManager<T> predicateManager = PredicateFactory<T>.create(typeof(T));
            List<IPredicateOnList<T>> predicateList = predicateManager.getListPredicates();
            foreach (PredicateOnList<T> p in predicateList)
            {
                PredicatesOnListViewModel.Add(new PredicateOnListViewModel<T>(p));
            }
        }

        public List<IPredicateOnList<T>> getListPredicates()
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
