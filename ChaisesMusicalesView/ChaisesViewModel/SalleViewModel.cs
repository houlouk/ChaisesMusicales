using MicroMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChaisesMusicales
{
    public class SalleViewModel<T>:IRandomizeList
    {
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

            IListOfPredicateOnListViewModel<T> predicates;
            IListRandomizer<IChaiseViewModel, T> randl;

            predicates = new ListOfPredicateOnListViewModel<T,IChaiseViewModel>();
            randl =PredicateFactory<T,IChaiseViewModel> .createIRandomizer(typeof(T)) ;

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
