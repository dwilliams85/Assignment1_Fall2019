﻿using System;

namespace Assignment1_Fall2019
{
    class Program
    {
        static void Main(string[] args)
        {
            //integers for self diving array
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);


            int n2 = 5;
            printSeries(n2);

            int n3 = 5;
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = NumJewelsInStones(J, S);
            Console.WriteLine(r4);

        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                int N = y - x + 1;
                int[] a = new int[N];
                int count = 0;
                for (int i = x; i <= y; i++)
                {
                    if (isSelfDividing(i))
                    {
                        a[count++] = i;
                        Console.WriteLine(i.ToString());
                    }
                }
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n)
        {
            try
            {
                int i = 1;
                while (i <= n)
                {
                    Console.Write("{0} ", i);
                    i++;
                    int j = 1;
                    while (j <= i)
                    {
                        Console.Write("{0} ", j);
                        j++;
                    }
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
                //Declare integers
                int i, j, k;

                for (i = 0; i < 5; i++)
                {
                    for (j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 0; k < n; k++)
                    {
                        Console.Write("* ");
                    }
                    n--;
                    Console.WriteLine();
                }
            }

            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int NumJewelsInStones(int[] J, int[] S)
        {
            try
            {
                {
                    int count = 0;
                    foreach (int d in S)
                    {
                        foreach (int b in J)
                        {
                            if (d == b)
                                count++;
                        }
                    }
                    return count;

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }


        static bool isSelfDividing(int n)
        {
            int currentDigit = 0;
            int actualNumber = n;
            while (n > 0)
            {
                currentDigit = n % 10;
                if ((currentDigit == 0) || (actualNumber % currentDigit != 0))
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }

    }
}

