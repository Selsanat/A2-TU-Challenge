using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return a+b;
        }

        public static bool IsMajeur(int a)
        {
            if (a < 0|| a>=150)
            {
                throw new ArgumentException();
            }
            return a>=18;
        }
        public static bool IsEven(int a)
        {
            return a%2==0;
        }
        public static bool IsDivisible(int a, int b)
        {
            return a%b==0;
        }
        public static bool IsPrimary(int a)
        {
            if (a <= 1) {
                return false;
            }
            if (a == 2) {
                return true;
            }
            if (a % 2 == 0) {
                return false;
            }
            for (int i = 3; i < a; i++)
            {
                if (a%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static List<int> GetAllPrimary(int a)
        {
            List<int> resultat = new List<int>();
            for(int i = 0; i < a+1; i++)
            {
                if (IsPrimary(i))
                {
                    resultat.Add(i);
                }
            }
            return resultat;
        }

        public static int Power2(int a)
        {
            return a * a;
        }
        public static int Power(int a, int b)
        {
            int result = a;
            for(int i = 1; i < b;i++)
            {
                result *= a;
            }
                return (result);
        }
        public static int IsInOrder(int a, int b)
        {
            if (a == b)
            {
                return 0;
            }
            if(a < b){
                return 1;
            }
            return -1;
        }

        public static int IsInOrderDesc(int a, int b)
        {
            if (a == b)
            {
                return 0;
            }
            if (a < b)
            {
                return -1;
            }
            return 1;
        }

        public static bool IsListInOrder(List<int> liste)
        {
            for(int i = 0; i < liste.Count-1;i++)
            {
                if (IsInOrder(liste[i], liste[i + 1])==-1)
                {
                    return false;
                }
            }
            return true;
        }
        public static List<int> Sort(List<int> liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                for (int y = 0; y < liste.Count; y++)
                {
                    if (!IsListInOrder(liste))
                    {
                        if (liste[i] < liste[y])
                        {
                            (liste[i],liste[y]) = (liste[y],liste[i]) ;
                        }
                    }
                }
            }
            return liste;
        }

        public static List<int> GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            List<int> retour = (Sort(toSort));
            if (isInOrder == MyMathImplementation.IsInOrderDesc)
            {
                for(int i=0; i < retour.Count()/2; i++)
                {
                    (retour[retour.Count()-1-i], retour[i]) = (retour[i], retour[retour.Count()-1-i]);
                }
            }
            return retour;
        }
    }
}
