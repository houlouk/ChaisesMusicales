using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
//test git
namespace ChaisesMusicales
{
    internal class IntListRandomizer<T>:IListRandomizer<T,int>
    {
        private int count;

        public IntListRandomizer(int count)
        {
            this.count = count;
        }

        public List<T> randomizeList(List<T> list,List<IPredicateOnList<int>> predicates)
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

            List<T> cvm = new List<T>();
            foreach (int i in mixIntegers)
            {
                cvm.Add(list[i]);

            }

            return cvm;

        }
    }
    }