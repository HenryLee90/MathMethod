using System;

namespace MathMethods
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Jacob");
            Add(7, 4, 50);
            Subtract(70, 15);
            Multiply(6, 82, 5);
            Console.WriteLine (Divide(50, 5));
            int answer = Divide(77, 11);
            Console.WriteLine(answer);

            Console.WriteLine($"Pick A Number Please?.");
            var userAnswer = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please Choose Another Number?.");
            var secUserAnswer = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please Choose Another Number Again?.");
            var thirdUserAnswer = int.Parse(Console.ReadLine());
            Add (userAnswer, secUserAnswer, thirdUserAnswer);




        }

        public static void Add(int num1, int num2, int num3 )
        {
            int sum = num1 + num2 + num3;
          Console.WriteLine(sum);            

        }
        public static void Subtract(int num1, int num2)
        {

            int sum = num1 - num2;
            Console.WriteLine(sum);

        }
        public static void Multiply(int num1, int num2, int num3)
        {
            int sum = num1 * num2 * num3;
            Console.WriteLine(sum);

        }        
        public static int Divide(int num1, int num2)
        {
           int sum = (num1 / num2);
            
            return sum;

        }
    }
}
