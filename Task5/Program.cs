using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 5
//Розробіть додаток, який знаходитиме мінімальне і
//максимальне значення у двовимірному масиві.
namespace Task5
{
    internal class Program
    {
        public static int Max(int[,] r)
        {
            int m = r[0,0];
            foreach (var i in r) 
                if (i > m) m = i;
            return m;
        }
        public static int Min(int[,] r)
        {
            int m = r[0, 0];
            foreach (var i in r)
                if (i < m) m = i;
            return m;
        }
        static void Main(string[] args)
        {
            int[,] arg1 = new int[3, 5];
            Random random = new Random();
            Console.WriteLine("The Initial Array: ");
            for (int i = 0; i < arg1.GetLength(0); i++)
            {
                for (int j = 0; j < arg1.GetLength(1); j++)
                {
                    arg1[i, j] = random.Next(0, 30);
                    Console.Write(arg1[i, j]+"; ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"The Maximum element ot the Array: {Max(arg1)}");
            Console.WriteLine($"The Minimum element ot the Array: {Min(arg1)}");
        }
    }
}
