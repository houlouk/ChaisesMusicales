using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

//test git
namespace ChaisesMusicales
{
    internal class IntListRandomizer<T>:IListRandomizer<T,Predicate<List<int>>>
    {

        public List<T> randomizeList(List<T> list,List<Predicate<List<int>>> predicates)
        {
            List<int> mixIntegers = mixNIntegers(predicates, list.Count());
            List<T> cvm = new List<T>();
            foreach (int i in mixIntegers)
            {
                cvm.Add(list[i]);

            }

            return cvm;

        }

        private List<int> mixNIntegers(List<Predicate<List<int>>> predicates,int count)
        {
            List<int> mixIntegers = new List<int>();


            Random rnd = new Random();

            int v;

            for (int i = 0; i < count; i++)
            {
                ISet<int> vtab = new SortedSet<int>();
                do
                {
                    if (vtab.Count == count) { mixIntegers.Clear(); i = 0; } 
                    v = rnd.Next(0, count);
                    vtab.Add(v);
                }
                //TO CHANGE
                while (v == i || mixIntegers.Contains(v) || !predicates.TrueForAll(p => p(mixIntegers.Concat(new List<int>() { v }).ToList())));

                Console.Out.WriteLine(v);

                mixIntegers.Add(v);
            }

            return mixIntegers;


        }


    }


    }