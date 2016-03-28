using ChaisesMusicales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaisesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SalleViewModel salle = new SalleViewModel();
            Console.Out.WriteLine(salle);
            salle.randomizeList();
            Console.Out.WriteLine(salle);

            Console.ReadKey();

        }
    }
}
