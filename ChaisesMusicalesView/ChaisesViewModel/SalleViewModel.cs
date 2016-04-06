using MicroMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using System.Windows.Input;

namespace ChaisesMusicales
{
    public class SalleViewModel:IRandomizeList
    {
        private IListOfPredicateOnListViewModel<Predicate<List<int>>> predicates;

        private SalleManager salleManager = new SalleManager();
        private ObservableCollection<IChaiseViewModel> chaisesViewModel = new ObservableCollection<IChaiseViewModel>();

        public ObservableCollection<IChaiseViewModel> ChaisesViewModel
        {
            get { return this.chaisesViewModel; }
            set { this.chaisesViewModel = value; }
        }
        public SalleViewModel()
        {
            List<Chaise> salle = salleManager.getSalle();
            foreach (Chaise c in salle)
            {
                chaisesViewModel.Add(new ChaiseViewModel(c));
            }
        }

        public void randomizeList()
        {

            IListRandomizer<IChaiseViewModel, Predicate<List<int>>> randl;

            predicates = new ListOfPredicateOnListViewModel<Predicate<List<int>>,IChaiseViewModel>();
            randl =PredicateFactory<Predicate<List<int>>,IChaiseViewModel> .createIRandomizer(typeof(Predicate<List<int>>)) ;

            List<IChaiseViewModel> cvm = randl.randomizeList(chaisesViewModel.ToList(),predicates.getListPredicates());
         
           
            this.chaisesViewModel.Clear();
            foreach (IChaiseViewModel vm in cvm)
                chaisesViewModel.Add(vm);

            


        }

        public ICommand RandomizeSalle { get { return new RelayCommand(randomizeList, CanRandomizeSalleExecute); } }

        bool CanRandomizeSalleExecute()
        {
            return true;
        }


      

        public override string ToString()
        {
            string s = "";
            foreach (ChaiseViewModel c in chaisesViewModel)
            {
                s += c.ChaiseName+"\n";
            }
            return s;
        }
    }
}
