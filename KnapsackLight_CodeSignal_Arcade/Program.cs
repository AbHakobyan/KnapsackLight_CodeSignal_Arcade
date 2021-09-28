using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackLight_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1 = 15;
            int w1 = 2;
            int v2 = 20;
            int w2 = 3;
            int x = knapsackLight(v1, w1, v2, w2, 2);
            Console.WriteLine(x);
        }

        static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            
            if (weight1 + weight2 <= maxW)
            {
                return value1 + value2;
            }
            if (weight1 > maxW && weight2 > maxW)
            {
                return 0;
            }
            if (weight2 == maxW && weight1 < maxW)
            {
                if (value1 > value2)
                {
                    return value1;
                }
                else
                {
                    return value2;
                }
            }
            else if (weight1 == maxW  && weight2 <maxW)
            {
                if (value1 > value2)
                {
                    return value1;
                }
                else
                {
                    return value2;
                }
            }
            else if (weight1 + weight2 > maxW)
            {
                if (weight1 == maxW)
                {
                    return value1;
                }
                else
                {
                    return value2;
                }
            }

            return 0;
        }
    }
}
