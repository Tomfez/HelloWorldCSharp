using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] tabFibonnaci = new int[2];

            bool wrongInput = true;
            do
            {
                try
                {
                    Console.WriteLine("Veuillez entrer un nombre :");
                    Algorithms.Fibonnaci(Console.ReadLine());
                    wrongInput = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (wrongInput);

           
            Console.ReadLine();
        }

        private static int GetPositiveNumber()
        {
          

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
