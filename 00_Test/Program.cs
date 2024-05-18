 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /*
            int Add(int a, int b)
            {
                int sum1 = a + b;
                return sum1;
            }
            Console.WriteLine("請輸入數值1:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入數值2：");
            int y = Convert.ToInt32(Console.ReadLine());
            int total = Add(x, y);
            Console.WriteLine($"{x}+{y}={total}");
            */

            string s = "hello";
            byte[] asciiBytes = System.Text.Encoding.ASCII.GetBytes(s);
            int sum = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                
                    sum += Math.Abs(asciiBytes[i] - asciiBytes[i + 1]);
              

                
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
