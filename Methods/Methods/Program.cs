using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //task-1
            //string word = "Hello";
            //char letter = 'l';
            //int count = 0;
            //foreach (char item in word)
            //{
            //    if (letter == item)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //task-2
            //string[] arr = { "Osman", "Javidan", "Zahid","Elmeddin", "Eli" };
            //string maxLenghtWord = arr[0];
            //foreach (string item in arr)
            //{
            //    if (maxLenghtWord.Length < item.Length)
            //    {
            //        maxLenghtWord = item;
            //    }
            //}
            //Console.WriteLine(maxLenghtWord);
            #endregion

            #region Try,catch,finally

            //Console.WriteLine("Eded daxil edin:");
            //string x = Console.ReadLine();

            //bool condition = true;
            //while (condition)
            //{
            //    try
            //    {
            //        int result = int.Parse(x);
            //        Console.WriteLine(result);
            //        condition = false;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Zehmet olmasa eded daxil edin:");
            //        x = Console.ReadLine();
            //    }
            //    finally
            //    {
            //        Console.WriteLine("finally ishledi");
            //    }
            //}


            #endregion

            #region Methods
            //int result=Sum(5);
            //Console.WriteLine(result);
            //Console.WriteLine(GetWord());

            //Information("Kamran", "Jabiyev",18);
            //Info("Kamran","Jabiyev",30);
            //string[] arr = new string[3] { "Kamil", "Seynur", "Zahid" };
            //Info("Kamran","Jabiyev","Test");
            Console.WriteLine(Info(20, 18, 17, 18, 26, 20));
            #endregion
        }
        //method signature - method name,parametrs count,parametr's type
        //method overloading
        static int Info(params int[] arr)
        {
            int result = 0;
            foreach (int item in arr)
            {
                result += item;
            }
            return result;
        }
        static void Info(params string[] arr)
        {
            foreach (string item in arr)
            {
                Console.WriteLine($"params qebul eden:{item}");
            }
        }

        static void Info(string name, string surname = "Jabiyev")
        {
            Console.WriteLine($"2-parametr qebul eden:{name} {surname}");
        }

        static void Info(string name)
        {
            Console.WriteLine($"1-parametr qebul eden:{name}");
        }

        static void Info(string name, string surname, int age)
        {
            Console.WriteLine($"{name} {surname} {age}");
        }
        static void Info(int x)
        {
            Console.WriteLine(x);
        }



        //static int Sum(int x, int y) => x + y;

        /// <summary>
        /// Ededleri toplayir
        /// </summary>
        /// <param name="x">Birinci toplandir</param>
        /// <param name="y">Ikinci toplanandir</param>
        /// <returns>Cem qaytarir</returns>
        static int Sum(int x, int y=0)
        {
            if (x > y)
            {
                return x + y;
            }
            else
            {
                return x;
            }
        }
        
        static string[] GetWord()
        {
            return new string[2] { "Zahid","Kamil"};
        }

        static void Information(string name,string surname,int age)
        {
            if (age > 20)
            {
                Console.WriteLine($"{name} {surname} {age}");
                return;
            }
            Console.WriteLine($"{name} {surname}");
        }

        
    }
}


