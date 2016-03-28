using System;
using System.Collections.Generic;
using System.Linq;
//test git
namespace ChaisesMusicales
{
    internal class IntListRandomizer
    {
        internal List<int> mixNFirstIntegers(int N, List<IPredicateOnList<int>> predicates)
        {
            List<int> mixIntegers = new List<int>();


            Random rnd = new Random();

            int v;

            for (int i = 0; i < N; i++)
            {
                do
                {
                    v = rnd.Next(0, N);
                }
                //TO CHANGE
                while (v == i || mixIntegers.Contains(v) || !predicates.TrueForAll(p => p.RealPredicate(mixIntegers.Concat(new List<int>() { v }).ToList())));

                mixIntegers.Add(v);
            }

            return mixIntegers;

        }
    }
    }