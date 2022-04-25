namespace Assignment;

public class LinearSearch
{
    public static void Linear_Search(List<int> list, int value)
    {
        List<int> list_index = new List<int>();
        int smallest_difference = Math.Abs(list[0] - value);
        int index = 0;
        
        for (int i=0; i < list.Count; i++)
        {
            // difference between the item in the list and the value user wants
            int difference = Math.Abs(list[i] - value);

            if (difference == 0)
            {
                list_index.Add(i);
            }
            //we are looking for difference to be smallest
            // we want to compare this iteration of difference to the smallest previous one
            else if (difference < smallest_difference)
            {
                smallest_difference = difference;
                index = i;
            }
        }

        if (list_index.Count == 0)
        {
            list_index.Add(index);
        }

        Console.Write("\nThe value " + value + " shows up at index: ");

        foreach (var num in list_index)
        {
            Console.Write(num + ",");
        }
    }
}

// for each value in the list,
// we take the difference bw the list item and desired number
// return index of value with the smallest difference