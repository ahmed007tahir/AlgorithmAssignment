namespace Assignment;

// This class implements the Bubble Sort algorithm, which works by comparing each item of the list with the adjacent item and moving the position of the list accordingly
// "Bubble sort algorithm, also known as sinking sort, is the simplest sorting algorithm that runs through the list repeatedly, compares adjacent elements, and swaps them if they are out of order. "
public class BubbleSort
{

    // This method takes in an unsorted list of integers as an argument and sorts the list in ascending order 
    public static List<int> BubbleSortAscending(List<int> unsortedList)
    {
        // This will hold a clone of the unsorted list, as not to change the original list
        List<int> sortedList = unsortedList.ToList();

        // This initializes the outside loop 
        for (int j = 0; j <= sortedList.Count-2; j++)
        {
            // The inside loop begins here
            for (int i = 0; i <= sortedList.Count-2; i++)
            {
                // This statements compares the current item of the list to the adjacent value, it the current value is larger than it gets swapped with the adjacent value
                // this step will be repeated until the list is fully sorted
                if (sortedList[i] > sortedList[i+1])
                {
                    (sortedList[i], sortedList[i + 1]) = (sortedList[i + 1], sortedList[i]);
                }
            }
        }
        return sortedList;
    }
    

    // This method takes in an unsorted list of integers as an argument and sorts the list in descending order 
    public static List<int> BubbleSortDescending(List<int> unsortedList)
    {
        // This will hold a clone of the unsorted list, as not to change the original list
        List<int> sortedList = unsortedList.ToList();

        // This initializes the outside loop 
        for (int j = 0; j <= sortedList.Count-2; j++)
        {

            // The inside loop begins here
            for (int i = 0; i <= sortedList.Count-2; i++)
            {
                // This statements compares the current item of the list to the adjacent value, it the current value is larger than it gets swapped with the adjacent value
                // this step will be repeated until the list is fully sorted
                if (sortedList[i] < sortedList[i+1])
                {
                    (sortedList[i], sortedList[i + 1]) = (sortedList[i + 1], sortedList[i]);
                }
            }
        }
        return sortedList;
    }
}