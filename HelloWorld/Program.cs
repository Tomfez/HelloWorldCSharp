using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Calculatrice calculatrice = new Calculatrice();

            while (true)
            {
                Console.WriteLine("Choisissez l'opérateur (+,-,*,/) ou tapez 'c' pour réinitialiser:");
                string operateur = Console.ReadLine();

                Console.WriteLine("Ecrivez un nombre :");
                float number = float.Parse(Console.ReadLine());

                switch (operateur)
                {
                    case "+":
                        calculatrice.Add(number);
                        break;
                    case "-":
                        calculatrice.Substract(number);
                        break;
                    case "*":
                        calculatrice.Multiply(number);
                        break;
                    case "/":
                        calculatrice.Divide(number);
                        break;
                    case "c":
                        calculatrice.Reset();
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"Résultat : {calculatrice.GetCurrentValue()}");
            }
        }

    }
}
