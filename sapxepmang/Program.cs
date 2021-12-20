using System;

namespace sapxepmang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {

                Console.Write("a[{0}]: ",i);

                a[i] = int.Parse(Console.ReadLine());

            }

            Console.Write("offset: ");
            int offset = int.Parse(Console.ReadLine());


            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {

                int j = i - offset;

                if (j >= n)
                {
                    j = j - n;
                }
                else if (j < 0){
                    j = n + j;
                }

                b[i] = a[j];

            }

            for (int i = 0; i < n; i++)
            {

                Console.Write("{0}: ",b[i]);

            }


        }
    }
}
