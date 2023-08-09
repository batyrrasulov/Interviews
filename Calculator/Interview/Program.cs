using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview
{
    class Program
    {
        private static readonly int[][] _sampleInputs = new int[][] {
            new [] { 3,3,2,1,1},
            new [] { 1,2,3,4,5},
            new[] {-5,-1 },
            new [] { -2000000000,2000000000}
        };
        
        static void Main(string[] args)
        {
            foreach (var input in _sampleInputs)
            {
                RunForDataSet(input);
                Console.WriteLine();

            }
            Console.ReadKey();
        }

        private static void RunForDataSet(int[] set)
        {
            Console.WriteLine("Input: " + string.Join(",", set));

            foreach (var calculator in GetCalculators())
            {
                var ourAnswer = calculator.Calculate(set);
                var correctAnswer = calculator.GetAnswer(set);

                Console.Write(calculator.Caption + ": " + ourAnswer);
                if (ourAnswer != correctAnswer)
                    Console.Write("  Incorrect! Correct answer is " + correctAnswer);
                Console.WriteLine();
            }
        }

        private static IEnumerable<ICalculator> GetCalculators()
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                 .Where(x => typeof(ICalculator).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                 .Select(x => (ICalculator)Activator.CreateInstance(x));
        }
    }
}
