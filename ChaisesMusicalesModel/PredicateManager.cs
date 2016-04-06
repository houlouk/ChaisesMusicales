using System;
using System.Collections.Generic;

namespace ChaisesMusicales
{
    public  class PredicateManager:IPredicateManager<Predicate<List<int>>>
    {

        static Predicate<List<int>> atLeast2MoreForNext = atLeast2MoreForNextMethod;

        

        static Predicate<List<int>> atLeast2LessForNext = atLeast2LessForNextMethod;

       

        public  List<Predicate<List<int>>> getListPredicates()
        {
            List<Predicate<List<int>>> predicates = new List<Predicate<List<int>>>();


            predicates.Add(atLeast2LessForNext);
            predicates.Add(atLeast2MoreForNext);

            return predicates;
        }

        private static bool atLeast2MoreForNextMethod(IList<int> l)
        {
            //Le dernier élément n'a pas de voisin 
            for (int i=0;i<l.Count-1;i++)
            {
                if (l[i + 1] == l[i] + 1) return false;
            }
            return true;
        }
        private static bool atLeast2LessForNextMethod(IList<int> l)
        {
            for (int i = 0; i < l.Count - 1; i++)
            {
                if (l[i + 1] == l[i] - 1) return false;
            }
            return true;
        }
    }

    
    }
