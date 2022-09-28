using System;

namespace Syntax_Sugar_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} greater than or equal to nine";
            Console.WriteLine(response);
        }
    }
}
