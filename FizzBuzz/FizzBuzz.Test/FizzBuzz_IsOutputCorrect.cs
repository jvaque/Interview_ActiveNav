using NUnit.Framework;

namespace FizzBuzz.Test;

[TestFixture]
public class FizzBuzz_IsOutputCorrect
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(3)]
    [TestCase(6)]
    [TestCase(9)]
    public void Test_ReturnFizz(int value)
    {
        var result = FizzBuzz.Output(value);

        Assert.That(result, Is.EqualTo("Fizz"));
    }

    [TestCase(5)]
    [TestCase(10)]
    [TestCase(20)]
    public void Test_ReturnBuzz(int value)
    {
        var result = FizzBuzz.Output(value);

        Assert.That(result, Is.EqualTo("Buzz"));
    }

    [TestCase(15)]
    [TestCase(30)]
    [TestCase(45)]
    public void Test_ReturnFizzBuzz(int value)
    {
        var result = FizzBuzz.Output(value);

        Assert.That(result, Is.EqualTo("FizzBuzz"));
    }
}