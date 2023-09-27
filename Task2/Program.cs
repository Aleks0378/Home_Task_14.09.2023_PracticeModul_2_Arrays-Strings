using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 2
//Створіть додаток, який відображає кількість значень у
//масиві менше заданого параметра користувачем. Наприклад,
//кількість значень менших, ніж 7 (7 введено користувачем
//з клавіатури).
namespace Task2
{
    internal class Program
    {
        public static void LessThen(int n, int[] arr)
        {
            int q = 0;
            Console.WriteLine($"\nThe numbers less than {n}: ");
            foreach (var i in arr)
            {
                if (i < n)
                {
                    Console.Write(i + "; ");
                    q++;
                }
            }
            Console.WriteLine($"\nTotal numbers less than {n}: {q}");
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();
            Console.Write("The array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 50);
                Console.Write(arr[i] + "; ");
            }
            Console.WriteLine();
            Console.Write("Enter the integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            LessThen(n, arr);
        }
    }
}
