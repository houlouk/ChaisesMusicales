using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesMusicales
{
    class Program
    {
        static void Main(string[] args)
        {
            SalleViewModel<predicate> salle = new SalleViewModel<predicate>();
            Console.Out.WriteLine(salle);
            salle.randomizeList();
            Console.Out.WriteLine(salle);

            Console.ReadKey();

        }
    }
}
