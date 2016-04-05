using MicroMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    public class ChaiseViewModel:ObservableObject,IChaiseViewModel

    {
        private Chaise chaise;

        public ChaiseViewModel(Chaise chaise)
        {
            this.Chaise = chaise;
        }

        public Chaise Chaise
        {
            get
            {
                return chaise;
            }

            set
            {
                chaise = value;
            }
        }

        public String ChaiseName
        {
            get { return Chaise.Name; }
            set { Chaise.Name = value;
                RaisePropertyChanged("ChaiseName");
            } }
    }
}
