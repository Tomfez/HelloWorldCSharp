using System;
using System.Diagnostics;
using System.Threading;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            var file = System.IO.File.Create("C:/Users/Stagiaire001/Documents/Hallo.txt");
            file.Close();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Ligne a ecrire");
            string lineWrote = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (true)
            {
                Thread.Sleep(500);
                Console.WriteLine($"Temps passé depuis le début de l'éxecution {stopwatch.Elapsed}");
            }
            stopwatch.Stop();

            //List<string> listeMot = new List<string>();
            //ArrayList listeArray = new ArrayList();

            //while (true)
            //{
            //    Console.WriteLine("Entrez un mot:");
            //    var mot = Console.ReadLine();

            //    listeMot.Add(mot);
            //    listeArray.Add(mot);
            //    Console.WriteLine(listeMot);
            //    Console.WriteLine($"ArrayList {listeArray}");
            //}
        }

    }
}
