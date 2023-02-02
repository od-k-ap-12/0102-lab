using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0102
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1;

            Console.WriteLine("It's easy to win forgiveness for being wrong \nbeing right is what gets you into real trouble. \nBjarne Stroustrup");

            #endregion


            #region 2
            Console.WriteLine("Enter 5 numbers:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            int a4 = Convert.ToInt32(Console.ReadLine());
            int a5 = Convert.ToInt32(Console.ReadLine());
            int summ = a1 + a2 + a3 + a4 + a5;
            Console.WriteLine($"Summ={summ}");
            int mult = a1 * a2 * a3 * a4 * a5;
            Console.WriteLine($"Mult={mult}");
            int min = a1, max = a1;
            if (a2 > a1)
            {
                max = a2;
            }
            else if (a2 < a1)
            {
                min = a2;
            }

            if (a3 > a2)
            {
                max = a3;
            }
            else if (a3 < a2)
            {
                min = a3;
            }

            if (a4 > a3)
            {
                max = a4;
            }
            else if (a4 < a3)
            {
                min = a4;
            }

            if (a5 > a4)
            {
                max = a5;
            }
            else if (a5 < a4)
            {
                min = a5;
            }

            Console.WriteLine($"Min={min}");
            Console.WriteLine($"Max={max}");

            #endregion

            #region 3
            int n1, n2, n3, n4, n5, n6;
            Console.WriteLine("Enter a six-digit number:");
            int num = Convert.ToInt32(Console.ReadLine());
            n1 = num % 10;
            n2 = num % 100 / 10;
            n3 = num % 1000 / 100;
            n4 = num % 10000 / 1000;
            n5 = num % 100000 / 10000;
            n6 = num / 100000;
            Console.WriteLine($"Inverted={n1}{n2}{n3}{n4}{n5}{n6}");

            #endregion

            #region 4
            Console.WriteLine("Enter a range:");
            int bordermin = Convert.ToInt32(Console.ReadLine());
            int bordermax = Convert.ToInt32(Console.ReadLine());
            int firstnum = 0;
            int secondnum = 1;
            int currentnum;
            Console.WriteLine($"{firstnum}");
            bool i = true;
            while (i == true)
            {
                currentnum = firstnum + secondnum;
                if (currentnum >= bordermin)
                {
                    if (currentnum > bordermax)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{currentnum}");
                        firstnum = secondnum;
                        secondnum = currentnum;
                    }
                }
            }
            #endregion

            #region 5
            int A = 3, B = 7;
            for (int k = A; k <= B; k++)
            {
                for (int j = 1; j <= k; j++)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();
            }
            #endregion

            #region 6
            Console.WriteLine("Enter length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a symbol:");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter direction(1-vertical,2-horizontal):");
            string direction = Console.ReadLine();
            switch (direction)
            {
                case "1":
                    for(int l = 0; l < length; l++)
                    {
                        Console.WriteLine($"{symbol}");
                    }
                    break;
                case "2":
                    for (int l = 0; l < length; l++)
                    {
                        Console.Write($"{symbol} ");
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }


            #endregion
        }
    }
}
