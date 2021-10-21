using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WH6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string textinsert = Console.ReadLine();
            string[] stringArray = textinsert.Split();

            int p = 0;
            //string word;
            int word = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > p)
                {
                    p = stringArray[i].Length;
                    word = i;
                }
            }

            ////foreach (string s in stringArray)
            //{
            //    p = s.Length;
            //    word = s;
            //    Console.WriteLine(p);
            //}
            //int t = 0;
            //int[] newArray = { p };
            //foreach (int k in newArray)
            //{
            //    if (k>t)
            //    {
            //        t = k;
            //    }
            //}
            Console.WriteLine("Самое длинное слово, это {0}", stringArray[word]);
            Console.ReadKey();
        }
    }
}
