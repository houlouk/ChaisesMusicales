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
            SalleViewModel<Predicate<List<int>>> salle = new SalleViewModel<Predicate<List<int>>>();
            Console.Out.WriteLine(salle);
            salle.randomizeList();
            Console.Out.WriteLine(salle);

            Console.ReadKey();

        }
    }
}
