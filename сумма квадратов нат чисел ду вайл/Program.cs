using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сумма_квадратов_нат_чисел_ду_вайл
{
    class Program
    {
        static void Main()
        {
            int n = 10, k = 1, s = 0;
            Console.Write("Сумма 1^2 + 2^2 + 3^2 + ... + {0} =", ((n * (n + 1)) * ((2 * n + 1))) / 6);
            do
            {
                s += ((k * (k + 1)) * ((2 * k + 1))) / 6;
                k++;
            }
            while
                (k<=n);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
