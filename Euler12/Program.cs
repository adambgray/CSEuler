using System;
using System.Collections.Generic;

namespace Euler12
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleNumber = 0;
            int increment = 1;
            int factorCount = 0;

            while(factorCount < 501)
            {
                triangleNumber += increment;
                increment++;
                factorCount = GetFactors(triangleNumber).Count;

            }

            Console.WriteLine(triangleNumber);
            Console.ReadLine();
        }


        static List<int> GetFactors(int n)
        {
            List<int> factors = new List<int>();

            for (int i = 1; i < Math.Sqrt(n) + 1; i++)
            {
                if(n % i == 0)
                {
                    factors.Add(i);
                    factors.Add(n / i);
                }
            }

            return factors;
        }
    }
}
