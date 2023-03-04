using NUnit.Framework;

namespace FizzBuzz.Test;

[TestFixture]
public class FizzBuzz_IsOutputCorrect
{
    private FizzBuzz _fizzBuzz;

    [SetUp]
    public void Setup()
    {
        _fizzBuzz = new FizzBuzz();
    }

    [TestCase( 3, "Fizz")]
    [TestCase( 6, "Fizz")]
    [TestCase( 9, "Fizz")]
    [TestCase( 5, "Buzz")]
    [TestCase(10, "Buzz")]
    [TestCase(20, "Buzz")]
    [TestCase(15, "FizzBuzz")]
    [TestCase(30, "FizzBuzz")]
    [TestCase(45, "FizzBuzz")]
    [TestCase( 1, "1")]
    [TestCase( 2, "2")]
    [TestCase( 4, "4")]
    public void Test_Output(int value, string expectedResult)
    {
        var result = _fizzBuzz.Output(value);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}