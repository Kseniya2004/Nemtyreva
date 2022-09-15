using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nemtyreva
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[30];
            List<int> b = new List<int>();
            Random random = new Random();
            int sum = 0;
            for(int i = 0; i<30; i++)
            {
                A[i] = random.Next(-100,100);
                Console.WriteLine(A[i]);
                if (A[i]%5 == 0 && A[i]%7 != 0)
                {
                    sum += A[i];
                    b.Add(i);
                }                  
            }
            Console.WriteLine($"Количество: {b.Count} и сумма: {sum} элементов по условию.");
            Console.ReadKey();
            
        }
    }
}
