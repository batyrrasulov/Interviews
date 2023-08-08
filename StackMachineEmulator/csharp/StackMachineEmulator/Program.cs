using System;

namespace StackMachineEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "13+62*7+*";
            var c = new Solution();
            int result = c.solution(str);
            Console.WriteLine(result);
        }
    }
}
