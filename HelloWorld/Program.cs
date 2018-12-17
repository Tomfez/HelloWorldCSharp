using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int max;
            //int min ;
            //int minVal;
            //int maxVal;
            int nbre;
            int[] tabFibonnaci = new int[2];

            //min = GetMinValue();
            //max = GetMaxValue();
            nbre = GetNombre();
            //minVal = Algorithms.Min(min, max);
            //maxVal = Algorithms.Max(min, max);
            Algorithms.Fibonnaci(nbre);

            //Console.WriteLine($"La valeur minimale est {minVal}");
            //Console.WriteLine($"La valeur maximale est {maxVal}");

            //Console.ReadLine();
        }

        private static int GetNombre()
        {
            Console.WriteLine("Veuillez entrer un nombre :");
           return int.Parse(Console.ReadLine());
        }

        private static int GetMaxValue()
        {
            Console.WriteLine("Entrez un nombre max: ");
            int maxStr = int.Parse(Console.ReadLine());

            if (maxStr < 0)
            {
                Console.WriteLine("Le nombre doit être supérieur à 0");
            }

            return maxStr;
        }

        private static int GetMinValue()
        {
            Console.WriteLine("Entrez un nombre min: ");
            int minStr = int.Parse(Console.ReadLine());

            if (minStr < 0)
            {
                Console.WriteLine("Le nombre doit être supérieur à 0");
            }

            return minStr;
        }

        private static void DisplayRange(int min, int max)
        {
            for (int i = min; i < max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
