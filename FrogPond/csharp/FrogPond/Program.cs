using System;

namespace FrogPond
{
    class Program
    {
        static void Main(string[] args)
        {
            var leafDrop = new[] { 1, 3, 1, 4, 2, 5 };
            var frogJumps = 3;
            var pondSize = 7;

            var c = new Solution();
            int result = c.solution(leafDrop, pondSize, frogJumps);
            Console.WriteLine(result);
        }
    }
}
