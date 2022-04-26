namespace Assignment;

public class LinearSearch
{
    public static void Linear_Search(List<int> list, int value)
    {
        List<int> list_index = new List<int>();
        int smallest_difference = Math.Abs(list[0] - value);
        int smallest_number = 0;
        int index = 0;
        
        for (int i=0; i < list.Count; i++)
        {
            // difference between the item in the list and the value user wants
            int difference = Math.Abs(list[i] - value);

            if (difference == 0)
            {
                list_index.Add(i);
            }
            
            // 
            else if (difference < smallest_difference)
            {
                smallest_difference = difference;
                smallest_number = list[i];
                index = i;
            }
        }

        // 
        if (list_index.Count == 0)
        {
            Console.WriteLine("The number "+ value + " does not exist within the list! The next closest number is " + smallest_number + " at index" + index);
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