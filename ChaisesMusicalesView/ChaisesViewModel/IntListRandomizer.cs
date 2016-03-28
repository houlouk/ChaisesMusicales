using System;
using System.Collections.Generic;
using System.Linq;
//test git
namespace ChaisesMusicales
{
    internal class IntListRandomizer:IListRandomizer<int>
    {
        private int count;

        public IntListRandomizer(int count)
        {
            this.count = count;
        }

        public List<int> randomizeList(List<IPredicateOnList<int>> predicates)
        {
            List<int> mixIntegers = new List<int>();


            Random rnd = new Random();

            int v;

            for (int i = 0; i < count; i++)
            {
                do
                {
                    v = rnd.Next(0, count);
                }
                //TO CHANGE
                while (v == i || mixIntegers.Contains(v) || !predicates.TrueForAll(p => p.RealPredicate(mixIntegers.Concat(new List<int>() { v }).ToList())));

                mixIntegers.Add(v);
            }

            return mixIntegers;

        }
    }
    }