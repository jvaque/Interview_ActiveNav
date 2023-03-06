using System;
using System.Collections.Generic;

namespace FizzBuzz;

public class FizzBuzz
{
    private readonly CountingGame _game;

	public FizzBuzz()
	{
        List<CountingRule> rules = new()
        {
            new CountingRule(15, "FizzBuzz"),
            new CountingRule(5, "Buzz"),
            new CountingRule(3, "Fizz")
        };

        _game = new CountingGame(rules);
    }

    public string Output(int value)
    {
        return _game.Output(value);
    }

    public void Play()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(this.Output(i));
        }
    }
}
