namespace LambdaExpressions;
internal static class ListSelector 
{
    public static IEnumerable<string> FilterByLetter(IEnumerable<string> list, Func<string, bool> filterFunc)
    {
        // Create a new list to store the filtered results
        var filteredList = new List<string>();

        foreach (var item in list)
        {
            if (filterFunc(item))
            {
                filteredList.Add(item);
            }
        }

        return filteredList; // Return the filtered list
    }

}
