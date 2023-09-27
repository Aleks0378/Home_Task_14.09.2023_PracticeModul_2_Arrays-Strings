using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 6
//Користувач вводить речення з клавіатури. Вам необ-
//хідно підрахувати кількість слів у ньому.
namespace Task6
{
    internal class Program
    {
        public static int WordsCount(string str)
        {
            return str.Split(' ').Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence: ");
            string str = Console.ReadLine();
            Console.WriteLine($"The sentence has {WordsCount(str)} words");
        }
    }
}
