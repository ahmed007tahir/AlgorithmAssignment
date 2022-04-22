namespace Assignment;

public class QuickSort
{
      public static void Quick_Sort_Ascending(List<int> list, int start, int end)
    {
        if (start < end)
        {
            int i = Partition_Ascending(list, start, end);
    
            Quick_Sort_Ascending(list, start, i - 1);
            Quick_Sort_Ascending(list, i + 1, end);
        }
    }
 
    private static int Partition_Ascending(List<int> list, int start, int end)
    {
    int p = list[end];
    int i = start - 1;
 
    for (int j = start; j <= end - 1; j++)
    {
        if (list[j] <= p)
        {
            i++;
            (list[i] , list[j]) = (list[j] , list[i]);
        }
    }

    (list[i + 1] , list[end]) = (list[end] , list[i + 1]);

    return i + 1;
    }

    public static void Quick_Sort_Descending(List<int> list, int start, int end)
    {
        if (start < end)
        {
            int i = Partition_Ascending(list, start, end);
    
            Quick_Sort_Descending(list, start, i - 1);
            Quick_Sort_Descending(list, i + 1, end);
        }
    }
 
    private static int Partition_Descending(List<int> list, int start, int end)
    {
    int p = list[end];
    int i = start - 1;
 
    for (int j = start; j <= end - 1; j++)
    {
        if (list[j] >= p)
        {
            i++;
            (list[i] , list[j]) = (list[j] , list[i]);
        }
    }

    (list[i + 1] , list[end]) = (list[end] , list[i + 1]);

    return i + 1;
    }
}