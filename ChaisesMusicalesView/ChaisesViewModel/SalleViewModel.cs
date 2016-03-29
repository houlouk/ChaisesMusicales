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
    public class SalleViewModel:IRandomizeList
    {
        private ListOfPredicateOnListViewModel predicates=new ListOfPredicateOnListViewModel();
        private SalleManager salleManager = new SalleManager();
        private ObservableCollection<ChaiseViewModel> chaisesViewModel = new ObservableCollection<ChaiseViewModel>();

        public ObservableCollection<ChaiseViewModel> ChaisesViewModel
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
            IListRandomizer<ChaiseViewModel,int> randl = new IntListRandomizer<ChaiseViewModel>(chaisesViewModel.Count);
            List<ChaiseViewModel> cvm = randl.randomizeList(chaisesViewModel.ToList(),predicates.getListPredicates());
         
           
            this.chaisesViewModel.Clear();
            foreach (ChaiseViewModel vm in cvm)
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
