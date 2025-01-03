namespace LambdaExpressions;

public delegate bool StringConditionAction(string input);
public delegate bool NumberConditionAction(int input);


public static class ListFilter
{
    public static List<string> Filter(StringConditionAction stringConditionAction, List<string> strings)
    {
        var result = new List<string>();

        foreach (var stringItem in strings)
        {
            if (stringConditionAction(stringItem))
                result.Add(stringItem);
        }

        return result;
    }

    public static List<int> FilterNumbers(NumberConditionAction numberConditionAction, List<int> numberList)
    {
        var result = new List<int>();

        foreach (var number in numberList)
        {
            if (numberConditionAction(number))
                result.Add(number);
        }

        return result;
    }
}
