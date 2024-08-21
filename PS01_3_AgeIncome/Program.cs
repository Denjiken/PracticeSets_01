using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_3_AgeIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 28;

            int monthlyIncome = 80000;

            if (age >= 25 && age <= 35 && monthlyIncome > 50000)
            {
                Console.WriteLine("Young Professional");
            }
            else if (age >= 36 && age <= 55 && monthlyIncome > 70000)
            {
                Console.WriteLine("Middle-Aged Professional");
            }
            else if (age >= 56 && monthlyIncome < 30000)
            {
                Console.WriteLine("Senior Citizen");
            }
            else
            {
                Console.WriteLine("Other");
            }
                Console.ReadLine();
        }
    }
}
