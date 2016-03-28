using System;
using System.Collections.Generic;

namespace ChaisesMusicales
{
    public static class PredicateManager
    {

        static predicate atLeast2MoreForNext = atLeast2MoreForNextMethod;

       

        static predicate atLeast2LessForNext = atLeast2LessForNextMethod;

       

        public static List<IPredicateOnList<int>> getListPredicates()
        {
            List<IPredicateOnList<int>> predicates = new List<IPredicateOnList<int>>();


            predicates.Add(new PredicateOnList<int>(atLeast2LessForNext));
            predicates.Add(new PredicateOnList<int>(atLeast2MoreForNext));

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
