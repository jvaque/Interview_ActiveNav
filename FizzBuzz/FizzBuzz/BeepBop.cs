
using System;
using System.Collections.Generic;

namespace FizzBuzz;

public class BeepBop
{
    private readonly CountingGame _game;

    public BeepBop()
	{
        List<CountingRule> rules = new()
        {
            new CountingRule(21, "BeepBop"),
            new CountingRule( 7, "Bop"),
            new CountingRule( 3, "Beep")
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
