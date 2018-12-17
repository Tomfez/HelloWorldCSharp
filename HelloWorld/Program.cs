using System;

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

            if (String.IsNullOrWhiteSpace(nom))
            {
                Console.WriteLine("Le nom n'a pas été renseigné");
            }

            Console.WriteLine("Entrez votre prenom: ");
            prenom = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(prenom))
            {
                Console.WriteLine("Le prénom n'a pas été renseigné");
            }
            else
            {
                Console.WriteLine($"Prenom: {prenom} Nom: {nom}");
            }

            Console.ReadLine();
        }

    }
}
