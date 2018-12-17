using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            string prenom;

            Console.WriteLine("Entrez votre nom: ");
            nom = Console.ReadLine();
            Console.WriteLine("Entrez votre prenom: ");
            prenom = Console.ReadLine();

            Console.WriteLine($"Prenom: {prenom} Nom: {nom}");
            Console.ReadLine();
        }
    }
}
