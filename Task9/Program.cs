using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 9
//Створіть додаток для підрахунку кількості входжень підрядка в рядок.
//Користувач вводить вихідний рядок і слово для пошуку. Додаток відображає результат пошуку. 
//Наприклад:
//користувач ввів: Why she had to go. I don't know, she wouldn't say;
//підрядок для пошуку: she;
//результат пошуку: 2.
namespace Task9
{
    internal class Program
    {
        public static int StringsCount(string str1, string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            int count = 0;
            while (str1.IndexOf(str2,StringComparison.Ordinal) >= 0)
            {
                count++;
                str1 = str1.Substring(str1.IndexOf(str2, StringComparison.Ordinal)+str2.Length+1);
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("\nEnter the word or substring you want to count in the sentence: ");
            string str2 = Console.ReadLine();
            Console.WriteLine("\nThe string to find: "+str2);
            Console.WriteLine($"The count result: {StringsCount(str1,str2)}\n\n");
        }
    }
}
