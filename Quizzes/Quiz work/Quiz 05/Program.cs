using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Tyra Oberholzer's C# Quiz 05.");
            string quiz = "I think, therefore I am";
            Console.WriteLine($"The quiz string [{quiz}].");
            string[] quizarr = quiz.Split(' ');
            int len = quizarr.Length;
            Console.WriteLine($"Length of string array is {len}");

            for (int i = len - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i} {quizarr[i]}");
            }
        }
    }
}
