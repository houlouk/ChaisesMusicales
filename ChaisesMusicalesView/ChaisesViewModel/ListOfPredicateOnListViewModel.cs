using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    class ListOfPredicateOnListViewModel
    {
        private ObservableCollection<PredicateOnListViewModel> predicatesOnListViewModel = new ObservableCollection<PredicateOnListViewModel>();

        public ObservableCollection<PredicateOnListViewModel> PredicatesOnListViewModel
        {
            get { return this.predicatesOnListViewModel; }
            set { this.predicatesOnListViewModel = value; }
        }
        public ListOfPredicateOnListViewModel()
        {
            
            List<IPredicateOnList<int>> predicateList = PredicateManager.getListPredicates();
            foreach (PredicateOnList<int> p in predicateList)
            {
                PredicatesOnListViewModel.Add(new PredicateOnListViewModel(p));
            }
        }

        internal List<IPredicateOnList<int>> getListPredicates()
        {
            List<IPredicateOnList<int>> predicates = new List<IPredicateOnList<int>>();
            foreach (PredicateOnListViewModel pvm in predicatesOnListViewModel)
            {
                predicates.Add(pvm.Predicate);

            }
            return predicates;
        }
    }
}
