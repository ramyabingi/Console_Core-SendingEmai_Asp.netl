using System;

namespace fibbonaci
{
    class Program
    {
        static void Main(string[] args)
        {

            ///////polyndrome string////////////
            string s = "Ramya";
            string rev = " ";
            char[] ch = s.ToCharArray();
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                rev = rev + ch[i];
            }
            Console.Write(rev);
            Console.WriteLine();


            string n1 = "RamyaSrikanth";
            int count = 0;
            for (int j = 0; j < n1.Length; j++)
            {
                count = count + 1;
            }
            Console.WriteLine(count);
            Console.WriteLine();

            //  Console.WriteLine("Hello World!");
            int a = 0;
            int b = 1;
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                a = b;
                b = sum;
                sum = a + b;
                Console.WriteLine(sum);
            }
            Console.WriteLine();


            int[] a1 = { 1, 2, 2, 4, 6, 6 };
            
            for (int e = 0; e <= a1.Length - 1; e++)
            {
                int c = 0;
                for (int f = 1; f <= a1[e]; f++)
                {
                    if (e % f == 0)
                    {
                        c = c + 1;
                    }

                }
                if (count == 2)
                {
                    Console.WriteLine(a1[e]);
                }



            }
        }
    }



}

