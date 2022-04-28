namespace Assignment;

public class LinearSearch
{
    // This method takes in two arguments: an integer list & a integer 'value'
    // It then iterates through the integer list comparing each item of the list with the integer 'value'
    // If the value exists inside the list, this method returns all the indices where the value occurred in the list
    // If the value does not exist inside the list, this method returns the index number and value of the item in the list, that is closest to the integer 'value'
    public static void Linear_Search(List<int> list, int value)
    {
        // initializing an integer list to hold the indices of item value in the list
        List<int> list_index = new List<int>();

        // this variable holds the value of the smallest numeric difference between the list items and 'value' 
        int smallest_difference = Math.Abs(list[0] - value);

        // this variable holds the value of the number closest to the desired number, given the desired number does not exist within the list
        int smallest_number = 0;
        
        // this variable holds the index of the number closest to the desired number, given the desired number does not exist within the list
        int index = 0;
        
        // this loop iterates through the list
        for (int i=0; i < list.Count; i++)
        {
            // this variable holds the value of the numeric difference between the current list item and 'value' 
            int difference = Math.Abs(list[i] - value);

            // the item matches the desired number if the difference between the two value is zero
            if (difference == 0)
            {
                // this list will hold all the indices in the case where the item occurs more than once in the list
                list_index.Add(i);
            }
            
            // in case the value does not exist inside the list, this statement store the index and value of the item closest to the desired item
            else if (difference < smallest_difference)
            {
                smallest_difference = difference;
                smallest_number = list[i];
                index = i;
            }
        }

        // this statement will check if the desired number was found within the list, or not
        // if not found, the value and the index of the value closest will be printed
        if (list_index.Count == 0)
        {
            Console.WriteLine("The number "+ value + " does not exist within the list! The next closest number is " + smallest_number + " at index" + index);
        }

        // if the value is found, then all the indices where the value occurs within the list are printed
        else
        {
            Console.Write("\nThe value " + value + " shows up at index: ");

            foreach (var num in list_index)
            {
                Console.Write(num + ",");
            }
        }
    }
}