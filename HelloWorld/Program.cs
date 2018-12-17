using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            string prenom;
            string[] fullname = new string[2];

            Console.WriteLine("Entrez votre nom: ");
            nom = Console.ReadLine();
            fullname[0] = nom;
           

            if (String.IsNullOrWhiteSpace(fullname[0]))
            {
                Console.WriteLine("Le nom n'a pas été renseigné");
            }

            Console.WriteLine("Entrez votre prenom: ");
            prenom = Console.ReadLine();
            fullname[1] = prenom;

            if (String.IsNullOrWhiteSpace(fullname[1]))
            {
                Console.WriteLine("Le prénom n'a pas été renseigné");
            }
            else
            {
                Console.WriteLine(fullname[0] + fullname[1]);
            }

            Console.ReadLine();
        }

    }
}
