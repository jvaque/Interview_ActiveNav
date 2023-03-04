using NUnit.Framework;

namespace FizzBuzz.Test;

[TestFixture]
public class BeepBop_IsOutputCorrect
{
    private BeepBop _beepBop;

    [SetUp]
    public void Setup()
    {
        _beepBop = new BeepBop();
    }

    [TestCase(21, "BeepBop")]
    [TestCase(42, "BeepBop")]
    [TestCase(84, "BeepBop")]
    [TestCase( 3, "Beep")]
    [TestCase(18, "Beep")]
    [TestCase(72, "Beep")]
    [TestCase( 7, "Bop")]
    [TestCase(14, "Bop")]
    [TestCase(70, "Bop")]
    [TestCase( 5, "5")]
    [TestCase(20, "20")]
    [TestCase(76, "76")]
    public void Test_Output(int value, string expectedResult)
    {
        var result = _beepBop.Output(value);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}