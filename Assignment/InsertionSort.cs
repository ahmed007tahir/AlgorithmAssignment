namespace Assignment;

public class InsertionSort
{
    public static List<int> InsertionSortAscending(List<int> unsortedList)
    {
        List<int> sortedList = unsortedList.ToList();
        int counter = 0;

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
        Console.WriteLine(counter);
        return sortedList;
    }
    
    public static List<int> InsertionSortDescending(List<int> unsortedList)
    {
        int counter = 0;
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
        Console.WriteLine(counter);
        return sortedList;
    }
}