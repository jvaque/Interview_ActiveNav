using System.Collections.Generic;

namespace FizzBuzz;

public class CountingGame
{
    private List<CountingRule> _rules;
    public CountingGame(List<CountingRule> rules)
	{
        _rules = rules;
	}

    public string Output(int value)
    {
        foreach (var rule in _rules)
        {
            if (value % rule.Value == 0)
            {
                return rule.Message;
            }
        }
        
        return value.ToString();
    }
}