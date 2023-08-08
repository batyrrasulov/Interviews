using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 15;

            var sln = new Solution();
            var result = sln.solution(n);

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
