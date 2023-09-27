using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
//Завдання 1
//Створіть додаток, який відображає кількість парних,
//непарних, унікальних елементів масиву.
namespace Task1
{
    internal class Program
    {
        public static void Even(int[] arr)
        {
            int q = 0;
            Console.Write("\nEven numbers: ");
            foreach (int i in arr)
                if (i % 2 == 0)
                {
                    Console.Write(i + "; ");
                    q++;
                }
            Console.WriteLine($"\nTotal even numbers: {q}");
        }
        public static void Odd(int[] arr)
        {
            int q = 0;
            Console.Write("\nOdd numbers: ");
            foreach (int i in arr)
                if (i % 2 != 0)
                {
                    Console.Write(i + "; ");
                    q++;
                }
            Console.WriteLine($"\nTotal odd numbers: {q}");
        }
        public static void Uniq(int[] arr)
        {
            int q = 0; bool temp = false;
            Console.Write("\nUnique numbers: ");
            for (int i=0; i<arr.Length;i++)
            {
                temp=true;
                for (int j=0; j<arr.Length;j++)
                    if (i!=j && arr[i] == arr[j]) temp=false;
                if (temp)
                {
                    Console.Write(arr[i] + "; ");
                    q++;
                }
            }
            Console.WriteLine($"\nTotal unique numbers: {q}");
        }
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();
            Console.Write("The array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0,50);
                Console.Write(arr[i] + "; ");
            }
            Console.WriteLine();
            Even(arr);
            Console.WriteLine();
            Odd(arr);
            Console.WriteLine();
            Uniq(arr);
            Console.WriteLine();
        }
    }
}
