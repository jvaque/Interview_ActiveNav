using System;
using System.Collections.Generic;

namespace FizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        FizzBuzz fizzBuzz = new FizzBuzz();

        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(fizzBuzz.Output(i));
        }

        Console.WriteLine("---------------------------------");

        BeepBop beepBop = new BeepBop();
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(beepBop.Output(i));
        }

        Console.WriteLine("---------------------------------");
    }
}