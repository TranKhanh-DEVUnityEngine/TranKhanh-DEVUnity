using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("n: ");

            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            int d = 0;

            for (int i = 0; i < n; i++)
            {

                Console.Write("a[{0}]: ", i);

                a[i] = int.Parse(Console.ReadLine());

                if (dic.ContainsKey(a[i]))
                {
                    dic[a[i]]++;
                }
                else
                {
                    dic.Add(a[i], 1);
                    d++;
                }

            }

            List<int> keys = dic.Keys.ToList();

            int max = 1;

            for (int i = 0; i < d; i++)
            {

                for (int j = i + 1; j < d; j++)
                {

                    if (Math.Abs(dic[keys[j]] - dic[keys[i]]) <= 1 && dic[keys[i]] + dic[keys[j]] > max)
                    {

                        max = dic[keys[i]] + dic[keys[j]];

                    }

                }

            }

            Console.Write(max);


            Console.ReadLine();


        }
    }
}