using System;
using System.Collections.Generic;

namespace FizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        List<CountingRule> rules = new()
        {
            new CountingRule(15, "FizzBuzz"),
            new CountingRule(5, "Buzz"),
            new CountingRule(3, "Fizz")
        };

        CountingGame fizzbuzz = new CountingGame(rules);

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(fizzbuzz.Output(i));
        }
    }
}