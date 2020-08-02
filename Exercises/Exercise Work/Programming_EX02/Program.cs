using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Programming_EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, sum 10 numbers.");
            int sum = SumTenInts(0, 0);
            char letterGrade = 'X';
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("\nPart 2, average 10 numbers.");
            double avg = AvgTenInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 3, average user predetermined number of scores.");
            Console.Write("How many scores fo you wish to enter? ");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 4, average non-predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {letterGrade}");
        }
        private static char ConvertNumericToLetterGrade(double grade)
        {
            char letterGrade = 'X';
            if (grade >= 90)
            {
                letterGrade = 'A';
                return letterGrade;
            }
            else if (grade >= 80)
            {
                letterGrade = 'B';
                return letterGrade;
            }
            else if (grade >= 70)
            {
                letterGrade = 'C';
                return letterGrade;
            }
            else if (grade >= 60)
            {
                letterGrade = 'D';
                return letterGrade;
            }
            else if (grade >= 50)
            {
                letterGrade = 'F';
                return letterGrade;
            }
            else
                return letterGrade;
        }
        private static double AvgAnyInts(int sum, int count)
        {
            Console.WriteLine("Please enter a score: ");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            sum += int.Parse(input);
            count++;
            if (value == -1)
                return sum / count;
            else
                return AvgAnyInts(sum, count);
        }
        private static double AvgUnkInts(int sum, int count, int numScores)
        {
            Console.WriteLine("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < numScores)
                return AvgUnkInts(sum, count, numScores);
            else
                return (sum / (numScores));
        }
        private static double AvgTenInts(int sum, int count)
        {
            Console.WriteLine("Enter score here: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return AvgTenInts(sum, count);
            else
                return sum/ count;
        }
        private static int SumTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return SumTenInts(sum, count);
            else
                return sum;
        }
    }
}





//Average ten scores: 80 points Create a console application that will accept ten test scores between 0
//and 100, average them, and report the numerical grade.For example, a teacher will input ten test scores
//and compute the average numerical grade.Assign a letter grade to the student.

//Average a speci c number of scores: 90 points Create a console application that will accept an
//arbitrary number test scores (as speci ed by the user) between 0 and 100, average them, and report a
//numerical grade for the average.For example, a teacher will input the total number of tests, then input
//the speci ed number of test scores and compute the average numerical grade.Assign a letter grade to the
//student.

//Average a non-speci c number of scores: 100 points Create a console application that will accept
//a number test scores (as calculated by the number of scores actually entered) between 0 and 100, average
//them, and report a letter grade for the average based on the usual scale.For example, a teacher will input
//any number test scores, and compute the average numerical grade and the letter grade.This part required
//you to program a stop value. You can choose any kind of stop value you want, typically stop values consist
//of \quit," \exit," Ctl-C, or Escape. I chose a negative one (-1) as a stop value, assuming that no student
//would ever score a negative grade on a test.Assign a letter grade to the student.
