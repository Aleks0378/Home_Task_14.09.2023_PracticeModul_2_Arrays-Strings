using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 4
//Дано 2 масиви розмірності M і N відповідно.
//Необхідно переписати до третього масиву загальні
//елементи перших двох масивів без повторень.
namespace Task4
{
    internal class Program
    {
        
        public static int[] Uniq(int[] arr1)
        {
            int[] arr = new int[arr1.Length];
            int q = 0;
            bool temp = false;
            for (int i = 0; i < arr1.Length; i++)
            {
                temp = true;
                for (int j = 0; j < arr1.Length; j++)
                    if (i!=j && arr1[i] == arr1[j])
                        temp = false;
                if (temp)
                {
                    arr[q] = arr1[i];
                    q++;
                }
            }
            int[] r = new int[q];
            for (int i = 0; i < q; i++)
                r[i] = arr[i];
            return r;
        }
        public static void PrintArr(int[] arr)
        { 
            foreach (var i in arr)
            {
                Console.Write(i+"; ");
            }
        }
    static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr1 = new int[10];
            for (int i=0; i<arr1.Length;i++)
                arr1[i] = random.Next(0,30);
            int[] arr2 = new int[20];
            for (int i = 0; i < arr2.Length; i++)
                arr2[i] = random.Next(0, 30);
            int[] arr1Uniq=Uniq(arr1);
            int[] arr2Uniq=Uniq(arr2);
            int[] arr3 = new int[arr1Uniq.Length+arr2Uniq.Length];
            for (int i = 0,j=0;i < arr3.Length; i++)
            {
                if (i < arr1Uniq.Length) arr3[i] = arr1Uniq[i];
                else 
                {
                    arr3[i] = arr2Uniq[j];
                    j++;
                }
            }
            Console.Write("\nArray 1: ");
            PrintArr(arr1);
            Console.Write("\nArray 2: ");
            PrintArr(arr2);
            Console.Write("\nArray 3: ");
            PrintArr(arr3);
            Console.WriteLine();
        }
    }
}
