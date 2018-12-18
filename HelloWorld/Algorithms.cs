using System;

namespace HelloWorld
{
    public static class Algorithms
    {

        public static int Min(int val1, int val2)
        {
            if (val1 > val2)
            {
                return val2;
            }
            else
            {
                return val1;
            }
        }

        public static int Max(int val1, int val2)
        {
            if (val1 > val2)
            {
                return val1;
            }
            else
            {
                return val2;
            }
        }

        public static int[] Fibonnaci(int nbre)
        {
            int[] listeFibonnaci = new int[nbre];

            if (nbre < 2)
            {
                return new int[0];
            }

            listeFibonnaci[0] = 0;
            listeFibonnaci[1] = 1;

            for (int i = 2; i <= nbre; i++)
            {
                listeFibonnaci[i] = listeFibonnaci[i - 1] + listeFibonnaci[i - 2];
            }

            return listeFibonnaci;
        }

        public static bool IsPalindrome(string rndString)
        {
            int stringLength = rndString.Length;

            for (int i = 0; i < stringLength; i++)
            {
                if (rndString[i] != rndString[stringLength - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static int[] TriTableauEntier(int[] tabEntier, bool tri)
        {
            //Linq
            // arrayToSort.Where(x => x > 5);

            return tri ? tabEntier.arrayToSort.OrderBy(x => x).ToArray() : arrayToSort.OrderByDescending(x => x).ToArray();
        }
    }
}
