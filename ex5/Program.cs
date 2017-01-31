using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int rows = 0;
            rows = rows + (a * 60);
            //Thread t1 = new Thread(First);
            Thread t2 = new Thread(Second);
           // t1.Start();
            t2.Start();
            t2.Join();
            //t1.Join();
            System.Console.WriteLine();
            System.Console.WriteLine("\n Press Enter for Exit");
            System.Console.ReadLine();
            System.Console.WriteLine("EXIT");
        }
         
        private static void Second()
        {
            int a = 0;
            Random random = new Random();
            a = random.Next(1, 20);
            int k=0;
            while (k < a)
            {
                int asterisks = 0;
                while (asterisks < 60)
                {
                    Console.Write("*");
                    asterisks++;
                }
                Console.WriteLine();
                k++;
            }
        }

        private static void First()
        {
            int d = 0;
            Random random = new Random();
            d = random.Next(1, 21);
            int g = 0;
            while (g < d)
            {
                int gardenGates = 0;
                while (gardenGates < 60)
                {
                    Console.Write("#");
                    gardenGates++;
                }
                Console.WriteLine();
            }
        }
    }
}
