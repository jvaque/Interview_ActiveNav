using NUnit.Framework;

namespace FizzBuzz.Test;

[TestFixture]
public class FizzBuzz_IsOutputCorrect
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Fizz()
    {
        var result = FizzBuzz.Output(3);

        Assert.That(result, Is.EqualTo("Fizz"));
    }
}