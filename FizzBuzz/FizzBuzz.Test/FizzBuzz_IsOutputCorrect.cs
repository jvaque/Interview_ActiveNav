using NUnit.Framework;
using System.Collections.Generic;

namespace FizzBuzz.Test;

[TestFixture]
public class FizzBuzz_IsOutputCorrect
{
    private CountingGame _fizzBuzz_Game;

    [SetUp]
    public void Setup()
    {
        List<CountingRule> rules = new()
        {
            new CountingRule(15, "FizzBuzz"),
            new CountingRule(5, "Buzz"),
            new CountingRule(3, "Fizz")
        };

        _fizzBuzz_Game = new CountingGame(rules);

    }

    [TestCase(3)]
    [TestCase(6)]
    [TestCase(9)]
    public void Test_ReturnFizz(int value)
    {
        var result = _fizzBuzz_Game.Output(value);

        Assert.That(result, Is.EqualTo("Fizz"));
    }

    [TestCase(5)]
    [TestCase(10)]
    [TestCase(20)]
    public void Test_ReturnBuzz(int value)
    {
        var result = _fizzBuzz_Game.Output(value);

        Assert.That(result, Is.EqualTo("Buzz"));
    }

    [TestCase(15)]
    [TestCase(30)]
    [TestCase(45)]
    public void Test_ReturnFizzBuzz(int value)
    {
        var result = _fizzBuzz_Game.Output(value);

        Assert.That(result, Is.EqualTo("FizzBuzz"));
    }

    [TestCase(1, "1")]
    [TestCase(2, "2")]
    [TestCase(4, "4")]
    public void Test_ReturnNumber(int value, string expectedResult)
    {
        var result = _fizzBuzz_Game.Output(value);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}