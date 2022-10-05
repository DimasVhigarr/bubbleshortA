using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bubbleshortA
{
    class Program
    {
        private int[] a = new int[20];

        private int n;

        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20) break;
                else
                {
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 element. \n");

                }
                Console.WriteLine("");
                Console.WriteLine("----------------------");
                Console.WriteLine("Masukkan element Array");
                Console.WriteLine("----------------------");

                for (int i = 0; i < n; i++)
                {
                    Console.Write("<" + (i + 1) + ">");
                    string s1 = Console.ReadLine();
                    a[1] = Int32.Parse(s1);
                }
            }
            public void display()
            {
                Console.WriteLine("");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Element array yang telah tersusun");
                Console.WriteLine("---------------------------------");
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(a[j]);
                }
                Console.WriteLine("");
            }

            public void BubbleSortArray()
            {
                for (int i = 1; i < n; i++)
                {
                    for (int j = 0; j < n-i; j++)
                    {
                        if (a[j] < a[j + 1])
                        {
                            int temp;
                            temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }
                    }
                }
            }
            
        }
    }
}
