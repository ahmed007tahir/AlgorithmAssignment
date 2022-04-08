namespace Assignment;

public class InsertionSort
{
    public static List<int> Insertionsort(List<int> list)
    {
        for (int i = 0; i <= list.Count - 2; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (list[j - 1] > list[j])
                {
                    (list[j - 1], list[j]) = (list[j], list[j - 1]);
                }
            }
        }
        return list;
    }
}