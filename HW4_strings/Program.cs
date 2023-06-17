using System;
using System.Text.RegularExpressions;

namespace HW4_strings // Note: actual namespace depends on the project name.
{
    public static class Extensions
    {
        public static string Filter(this string str, List<char> charsToRemove)
        {
            foreach (char c in charsToRemove) {
                str = str.Replace(c.ToString(), String.Empty);
            }
 
            return str;
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Console.WriteLine(Task1());//"test" to "testing"
            //Console.WriteLine(Task2());//Welcome to the TMS lessons. 
            //Task3(); //separate string by 'abc'
            //Console.WriteLine(Task4());
            //Task5();
            Task6();
        }

        //<summary>
        //Задать строку содержащую внутри цифры и несколько 
        //повторений слова test, Заменить в строке все вхождения 'test' на 'testing'.
        //</summary>
        public static string Task1()
        {
            var stringOne = "23 jgg test .fhjtestfjg llfj test";
            string syringTwo = stringOne.Replace("test", "testing");
            return syringTwo;
        }
        
        /*<summary>
         *  Создайте переменные, которые будут хранить следующие слова:
         * (Welcome, to, the, TMS, lessons)выполните конкатенацию слов
         * и выведите на экран следующую фразу: Welcome to the TMS lessons. 
         *///</summary>
        public static string Task2()
        {
            string s1 = "Welcome";
            string s2 = "to";
            string s3 = "the";
            string s4 = "TMS";
            string s5 = "lessons";

            string[] values = new string[] { s1, s2, s3, s4, s5 };

            string s6 = string.Join(" ", values);
            return s6;
        }
        
        /* <summary>
         * teamwithsomeofexcersicesabcwanttomakeitbetter.
         * Необходимо найти в данной строке "abc", записав всё что
         * до этих символов в переменную firstPart, а также всё, 
         * что после них во вторую secondPart.
         */ //<summary>
        public static void Task3()
        {
            string string1 = "teamwithsomeofexcersicesabcwanttomakeitbetter";

            string[] parts = string1.Split("abc");
            string firstPart = parts[0];
            string secondPart = parts[1];
            
            Console.WriteLine("firstPart = " + firstPart);
            Console.WriteLine("secondPart = " + secondPart);
        }

        /*
         * Дана строка: Good day
         * Необходимо с помощью метода substring удалить слово "Good".
         * После чего необходимо используя команду insert создать строку
         * со значением: The best day!!!!!!!!!.
         * Заменить последний "!" на "?" и вывести результат на консоль.
         */
        public static string Task4()
        {
            string text = "Good day";
            text = text.Substring(0, text.Length - 4);

            string text2 = "The best !!!!!!!!!";
                           
           string text3 = text2.Insert(9, "day ");
           text3 = text3.Substring(0,text3.Length-1);
           text3 = text3.Insert(text3.Length, "?");

           return text3;
        }
        
        /*
         * Введите с консоли строку, которая будет содержать буквы и цифры.
         * Удалите из исходной строки все цифры и выведите их на экран.
         * (Использовать метод Char.IsDigit(), его не разбирали на уроке,
         * посмотрите, пожалуйста, документацию этого метода самостоятельно)
         */

 
        public static void Task5()
        {

            string stringOne = Convert.ToString(Console.ReadLine());
            List<char> digitsToRemove = new List<char>() { '0' ,'1', '2' ,'3', '4', '5', '6', '7', '8', '9' };

            foreach (char c in stringOne)
            {
                if (Char.IsDigit(c))
                {
                    Console.Write(c);
                }
            }
            Console.WriteLine();
            Console.WriteLine(stringOne = stringOne.Filter(digitsToRemove));
        }

        /* Задайте 2 предложения из консоли.
         * Для каждого слова первого предложения определите
         * количество его вхождений во второе предложение.
         */
        public static void Task6()
        {
            string stringOne = Convert.ToString(Console.ReadLine());
            string stringTwo = Convert.ToString(Console.ReadLine());

            string[] words = stringOne.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            for (int i = 0; i < words.Length-1; i++)
            {
                string find = words[i];
                var matches = Regex.Matches(stringTwo, find).Count;
                Console.WriteLine("\"{0}\" = {1}", find, matches);
            }
            
        }

    }
}