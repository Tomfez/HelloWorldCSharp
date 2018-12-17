using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Faites un choix: ");

            //var choix = int.Parse(Console.ReadLine());

            //switch (choix)
            //{
            //  case  1:
            //        Console.WriteLine(Hand.Thumb);
            //        break;
            //    case 2:
            //        Console.WriteLine(Hand.Index);
            //        break;
            //    case 3:
            //        Console.WriteLine(Hand.Middle);
            //        break;
            //    case 4:
            //        Console.WriteLine(Hand.Ring);
            //        break;
            //    case 5:
            //        Console.WriteLine(Hand.Pinky);
            //        break;
            //    default:
            //        break;
            //}

            Console.WriteLine("Faites un choix: ");
            int intVal = int.Parse(Console.ReadLine())-1;

            var allValues = Enum.GetValues(typeof(Hand));
            var sVal = allValues.GetValue(intVal).ToString();
            Console.WriteLine(sVal);
            Console.ReadLine();
        }

        enum Hand
        {
            Thumb,
            Pinky,
            Index,
            Middle,
            Ring
        }
    }
}
