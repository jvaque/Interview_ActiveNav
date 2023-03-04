using System;

namespace FizzBuzz;

static class FizzBuzz
{
    public static void Output(int value)
    {
        if (value % 15 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (value % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else if (value % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else
        {
            Console.WriteLine(value);
        }
    }
}
