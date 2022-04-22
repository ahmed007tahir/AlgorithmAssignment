namespace Assignment;

public class LinearSearch
{
    public static int Linear_Search(List<int> list, int value)
    {
        int index = 0;
        int difference = 0;
        for (int i=0; i < list.Count; i++)
        {
            if (Math.Abs(value-list[i]) <= difference)
            {
                difference = Math.Abs(value-list[i]);
                index = i;
            }
        }
    return index;
    }
}

// for each value in the list,
// we take the difference bw the list item and desired number
// return index of value with the smallest difference