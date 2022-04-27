namespace Assignment;

public class BubbleSort
{
    public static List<int> BubbleSortAscending(List<int> unsortedList)
    {
        int counter = 0;
        List<int> sortedList = unsortedList.ToList();

        for (int j = 0; j <= sortedList.Count-2; j++)
        {
            for (int i = 0; i <= sortedList.Count-2; i++)
            {
                if (sortedList[i] > sortedList[i+1])
                {
                    (sortedList[i], sortedList[i + 1]) = (sortedList[i + 1], sortedList[i]);
                    counter ++;
                }
            }
        }
        Console.WriteLine(counter);
        return sortedList;
    }
    
    public static List<int> BubbleSortDescending(List<int> unsortedList)
    {
        int counter = 0;
        List<int> sortedList = unsortedList.ToList();

        for (int j = 0; j <= sortedList.Count-2; j++)
        {
            for (int i = 0; i <= sortedList.Count-2; i++)
            {
                if (sortedList[i] < sortedList[i+1])
                {
                    (sortedList[i], sortedList[i + 1]) = (sortedList[i + 1], sortedList[i]);
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
        return sortedList;
    }
}