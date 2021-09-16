using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            char[] c = Console.ReadLine().ToCharArray();
            for (int i = 0; i< c.Length; i++)
            {
                x++;
                for (int j = i+1; j < c.Length; j++)
                {
                    if (c[i] != c[j])
                        x++;
                    else
                        break;
                }
            }

            Console.WriteLine(x.ToString());
            Console.ReadKey();
        }
    }
}
