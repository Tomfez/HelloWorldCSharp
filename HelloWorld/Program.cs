using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            User usr = new User();
            User usr2 = new User();

            usr.Name = "Toto";
            usr.Age = 25;
            usr2.Name = "Toto";
            usr2.Age = 25;

            Console.WriteLine(usr.Equals(usr2));

            Console.WriteLine($"Usr nom: {usr.Name}");
            Console.WriteLine($"Usr age: {usr.Age}");
            Console.WriteLine($"Usr2 nom: {usr2.Name}");
            Console.WriteLine($"Usr2 age: {usr2.Age}");

            Console.ReadLine();
        }
        

    }
}
