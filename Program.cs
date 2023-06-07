using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int i, j;
            int n = 5;
            for(i=1;i<=n;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write((char)(i + 64));
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

            string s1 = "Ramya";
            string rev = " ";
            char[] ch1 = s1.ToCharArray();
            for (int k = ch1.Length - 1; k>= 0; k--)
            {
                rev = rev + ch1[i];
            }
            Console.Write(rev);
            Console.WriteLine();

        }

    }
}
