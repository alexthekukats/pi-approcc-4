using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] alma = new double[164600000];
            double pi = Math.Sqrt(2); // Viète-féle sor // gyors
            alma[0] = pi /2;
            int x = 1;

            while (true)
            {
                
                    pi += 2;
                    pi = Math.Sqrt(pi);

                    alma[x] = pi / 2;

                    double alma2 = 1;
                    for (int n = 0; n < x; n++)
                    {
                        alma2 = alma[n] * alma2;
                    }
                        Console.WriteLine(((1 / alma2) * 2));
                        Console.ReadKey();
                x++;
            }
        }
    }
}
