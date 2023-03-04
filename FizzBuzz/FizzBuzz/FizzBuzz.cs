using System;

namespace FizzBuzz;

public static class FizzBuzz
{
    public static string Output(int value)
    {
        if (value % 15 == 0)
        {
            return "FizzBuzz";
        }
        else if (value % 5 == 0)
        {
            return "Buzz";
        }
        else if (value % 3 == 0)
        {
            return "Fizz";
        }
        else
        {
            return value.ToString();
        }
    }
}
