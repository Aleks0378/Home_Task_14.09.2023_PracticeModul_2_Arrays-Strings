using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 8
//Користувач вводить з клавіатури речення. Додаток має 
//підрахувати кількість голосних літер у реченні.
namespace Task8
{
    internal class Program
    {
        public static int VowelCount(string str)
        {
            char[] arr = { 'a', 'e', 'i', 'o', 'u', 'y' };
            str=str.ToLower();
            int count = 0/*, ind=0*/;
            while (str.IndexOfAny(arr)>=0)
            {
                count++;
                str = str.Substring(str.IndexOfAny(arr) + 1);
            }
            //for (int i = 0; i < str.Length; i++)
            //{
            //    ind = str.IndexOfAny(arr);
            //    if (i == ind)
            //    {
            //        count++;
            //        str=str.Substring(i+1);
            //        i = -1;
            //    }
            //}
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence: ");
            string str = Console.ReadLine();
            Console.WriteLine($"The sentence has {VowelCount(str)} vowels\n\n");
        }
    }
}
//Why she had to go. I don't know, she wouldn't say;