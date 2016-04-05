using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    class ChaisePlacee:Chaise
    {

        public ChaisePlacee(string Name,int Ligne,int Colonne) : base(Name)
        {
            this.Ligne = Ligne;
            this.Colonne = Colonne;
        }
        public int Ligne { get; private set; }

        public int Colonne { get; private set; }
    }
}
