using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekTuesdayLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Accumulation();
            Console.WriteLine("\n\n");
            landLostCalculator();
            Console.WriteLine("\n\n");
            spaceExploration();
            Console.WriteLine("\n\n");
            extraCredit();
            Console.WriteLine("\n\n\nNow for some string fun\n");
            reverseString(args);
            upper(args);
            superConencrate(args);
            
        }

        static void Accumulation()
        {
            Console.WriteLine("Accumulation\n");
            int deposit = 35;
            int year1 = 365 * deposit;
            int year2 = year1 * 2;
            int year5 = year1 * 5;
            int year10 = year1 * 10;
            Console.WriteLine("Year 1:  " + year1);
            Console.WriteLine("Year 2:  " + year2);
            Console.WriteLine("Year 5:  " + year5);
            Console.WriteLine("Year 10:  " + year10);
        }

        static void landLostCalculator()
        {
            int length = 0;
            int width = 0;
            do
            {
                Console.WriteLine("Land Lost Calculator\n");
                Console.WriteLine("Please enter the length of the Parcel in yards");
                length = int.Parse(Console.ReadLine());
                Console.WriteLine("\nPlease enter the Width of the Parcel in yards");
                width = int.Parse(Console.ReadLine());
                if (width < 1 && length < 1)
                    Console.WriteLine("\nInvald Input, please try again.\n");                
            }while (width < 1 && length < 1);
            int area = length * width;
            int perimeter = 3 * ((2 * length)+(2 * width));
            double total = (area * 5) + (perimeter * .75);

            Console.WriteLine("The amount owed for the parcel is $" + total);
        }
        static void spaceExploration()
        {
            Console.WriteLine("Space Exploration\n");
            double initialSpeed = 10000;
            for (int i = 0; i < 80; i++)
                initialSpeed = initialSpeed * 1.05;
            Console.WriteLine("After 2 hours of acceleration your speed would reach " + initialSpeed + " miles per hour.");
        }

        static void extraCredit()
        {
            Console.WriteLine("Extra Credit:  Quadratic Formula\n");
            Console.WriteLine("Please enter A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease enter B");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease enter C");
            int c = int.Parse(Console.ReadLine());

            double x1 = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            double x2 = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);

            Console.WriteLine("Your 2 X's are " + x1 + " and " + x2);
        }

        static void reverseString(string[] args)
        {
            for (int i = args.Length - 1; i > -1; i--)
                Console.Write(args[i] + " ");
            Console.WriteLine();
        }

        static void upper(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
                Console.Write(args[i].ToUpper() + " ");
            Console.WriteLine();
        }

        static void superConencrate(string[] args)
        {
            string result = "";
            for (int i = 0; i < args.Length; i++)
            {
                result = result + args[i];
                if (i < (args.Length - 1))
                    result = result + ",";
            }
            Console.WriteLine(result);
        }
    }
}
