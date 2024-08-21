using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_5_SwitchDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("A. Calculate Area");
            Console.WriteLine("P. Calculate Perimeter");
            Console.WriteLine("X. Exit");

            char choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (choice == 'A' || choice == 'P')
            {
                Console.Write("Enter the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());

                if (choice == 'A')
                {
                    double area = Math.PI * radius * radius;
                    Console.WriteLine("Area of the circle: " + area);
                }
                else
                {
                    double perimeter = 2 * Math.PI * radius;
                    Console.WriteLine("Perimeter of the circle: " + perimeter);
                }
            }
            else if (choice == 'X')
            {
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}