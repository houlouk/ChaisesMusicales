using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    public class SalleManager
    {
        static string[] names = { "Cyril", "Julien", "Elian", "Kevin", "Antoine", "Armel", "Gregory", "Thomas", "Gabriel", "Jeremy" };

        public List<Chaise> getSalle()
        {
            List<Chaise> salle = new List<Chaise>();


            for(int i = 0; i < names.Length; i++)
            {
                salle.Add(new Chaise(names[i]));
            }
            return salle;
        }
    }
}
