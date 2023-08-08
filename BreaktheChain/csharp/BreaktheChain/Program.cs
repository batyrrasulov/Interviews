using System;

namespace BreaktheChain
{
    class Program
    {
        static void Main(string[] args)
        {
            var chain = new[] { 5, 2, 4, 6, 3, 7 };

            var c = new Solution();
            int result = c.solution(chain);

            Console.WriteLine(result);
        }
    }
}
