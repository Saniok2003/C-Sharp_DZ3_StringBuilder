using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            //////////////////////  1
            string[] arr = new string[] { "Sanino", "Android", "Windows", "Magic", "POtato" };
            Array.Sort(arr);
            foreach (string sasd in arr)
            {
                Console.WriteLine(sasd);
            }

            //////////////////////  2
            Console.WriteLine("\n");
            string str = Console.ReadLine();
            string[] word = str.Split(' ');
            Console.WriteLine("Reversed:");
            Array.Reverse(word);
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i] + " ");
            }

            //////////////////////  4
            Console.WriteLine("Text:");
            string word1 = Console.ReadLine();
            word1 = word1.ToLower();
            string newWord = "";
            for (int i = word1.Length - 1; i >= 0; i--)
            {
                newWord += word1[i];
            }
            if (word1 == newWord)
            {
                Console.WriteLine("This is a palindrome.");
            }
            else
            {
                Console.WriteLine("This is not a palindrome.");
            }

            //////////////////////  5
            Console.WriteLine("\n");
            string st = Console.ReadLine();
            string[] wo = st.Split(' ');
            int ssf = int.Parse(Console.ReadLine());
            ssf = ssf - 1;
            char[] c = wo[ssf].ToCharArray();
            Console.Write(c[0]);

            //////////////////////  6
            string Wordd(ref string word)
            {
                return new string(word.Take(word.Length - 3).Concat("$$$").ToArray());
            }
            Console.Write("Enter sentence: ");
            string[] s = Console.ReadLine().Split(' ').ToArray();
            Console.Write("Lenght word: ");
            int length = int.Parse(Console.ReadLine());
            s = s.Select(v => v.Length == length ? Wordd(ref v) : v).ToArray();
            Console.WriteLine(string.Join(" ", s));

            //////////////////////  8
            string text = "Good day";
            string InsertString = " Hello yeah ";
            int ded = int.Parse(Console.ReadLine());
            text = text.Insert(ded - 1, InsertString);
            Console.WriteLine(text);

            //////////////////////  14
            Console.Write("Sentence: ");
            string sen = Console.ReadLine();
            string[] words = sen.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < 5)
                {
                    words[i] = "";
                }
            }
            Console.Write("New sentence: ");
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "" & i != 0) 
                {
                    Console.Write(" ");
                }
                Console.Write(words[i]);
            }

             */

            //////////////////////  15
            Console.WriteLine("\n");
            Console.Write("a=");
            ulong a = ulong.Parse(Console.ReadLine());
            Console.Write("b=");
            ulong b = ulong.Parse(Console.ReadLine());
            ulong с;
            с = a + b;
            Console.WriteLine(с);
             

        }

    }
}
