namespace Assignment;

public class InsertionSort
{
    public static List<int> InsertionSortAscending(List<int> unsortedList)
    {
        // This variable keeps track of the number of steps taken by the program
        int counter = 0;

        // This will hold a clone of the unsorted list, as not to change the original list
        List<int> sortedList = unsortedList.ToList();

        for (int i = 0; i <= sortedList.Count - 2; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (sortedList[j - 1] > sortedList[j])
                {
                    (sortedList[j - 1], sortedList[j]) = (sortedList[j], sortedList[j - 1]);
                    counter++;
                }
            }
        }
        Console.WriteLine("This algorithm sorted the list in " + counter + " steps.\n");
        return sortedList;
    }

    public static List<int> InsertionSortDescending(List<int> unsortedList)
    {
        // This variable keeps track of the number of steps taken by the program
        int counter = 0;

        // This will hold a clone of the unsorted list, as not to change the original list
        List<int> sortedList = unsortedList.ToList();

        for (int i = 0; i <= sortedList.Count - 2; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (sortedList[j - 1] < sortedList[j])
                {
                    (sortedList[j - 1], sortedList[j]) = (sortedList[j], sortedList[j - 1]);
                    counter++;
                }
            }
        }
        Console.WriteLine("This algorithm sorted the list in " + counter + " steps.\n");
        return sortedList;
    }
}