namespace FizzBuzz;

public class CountingRule
{
    private int _value;
    private string _message;

    public int Value
    {
        get { return _value; }
    }

    public string Message
    {
        get { return _message; }
    }

    public CountingRule(int value, string message)
    {
        _value = value;
        _message = message;
    }
}