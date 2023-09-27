using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 3
//Користувач вводить з клавіатури три числа.
//Необхідно підрахувати кількість разів послідовності цих трьох чисел в масиві.
//Наприклад:
//користувач ввів: 7 6 5;
//масив: 7 6 5 3 4 7 6 5 8 7 6 5;
//кількість повторень послідовності: 3.
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            Console.Write("The array: ");
            foreach (var i in arr)
                Console.Write(i+"; ");
            Console.Write("\n\nEnter first integer number: ");
            int n1=int.Parse(Console.ReadLine());
            Console.Write("Enter second integer number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third integer number: ");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The entered combination: {n1}{n2}{n3}");
            int q = 0;
            for (int i = 0; i < arr.Length-2; i++)
                if (arr[i]==n1 & arr[i+1]==n2 & arr[i+2]==n3) q++;
            Console.WriteLine($"Quantity of repeated combined numbers in the array: {q}");

        }
    }
}
