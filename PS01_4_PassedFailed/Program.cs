using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_4_PassedFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 90;

            string results = (score >= 50) ? "passed" : "failed";

            Console.WriteLine("Result: " + results);

            Consoleq.ReadLine();
        }
    }
}