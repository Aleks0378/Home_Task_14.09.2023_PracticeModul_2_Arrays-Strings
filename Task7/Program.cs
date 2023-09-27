using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 7
//Користувач вводить речення з клавіатури.
//Вам необхідно перевернути кожне слово речення і вивести результат на екрані. 
//Наприклад:
//користувач ввів: sun cat dogs cup tea;
//після перевороту: nus tac sgod puc aet.
namespace Task7
{
    internal class Program
    {
        public static string WordsReverse(string str)
        {
            string[] strArr = str.Split(' ');
            char[] temp = null;
            for (int i = 0; i < strArr.Length; i++)
            {
                temp = strArr[i].ToCharArray();
                strArr[i] = null;
                for (int j = temp.Length - 1; j >=0 ; --j)
                    strArr[i] += temp[j];
            }
            return string.Join(" ",strArr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence: ");
            string str = Console.ReadLine();
            Console.WriteLine($"The reversed sentence: {WordsReverse(str)}\n\n");
        }
    }
}
