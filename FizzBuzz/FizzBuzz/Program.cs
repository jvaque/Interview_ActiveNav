using System;

namespace FizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        FizzBuzz fizzBuzz = new FizzBuzz();

        fizzBuzz.Play();

        Console.WriteLine("---------------------------------");

        BeepBop beepBop = new BeepBop();

        beepBop.Play();

        Console.WriteLine("---------------------------------");
    }
}