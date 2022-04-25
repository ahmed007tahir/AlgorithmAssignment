namespace Assignment;

public class QuickSort
{
  
    public static void Quick_Sort_Ascending(List<int> unsortedList, int left, int right)
    {
        //If the left index is less than the right, the sort is not yet complete
        if (left < right)
        {
            //Take the element in the middle as a reference for comparison, move to the left less than it, move to the right greater than it
            int middle = unsortedList[(left + right) / 2];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                while (unsortedList[++i] < middle && i < right)
                    ; //Find elements smaller than the middle value from the left
                while (unsortedList[--j] > middle && j > 0)
                    ; //Find elements larger than the middle value from the right

                if (i >= j)
                    break;

                (unsortedList[i], unsortedList[j]) = (unsortedList[j], unsortedList[i]);
            }

            Quick_Sort_Ascending(unsortedList, left, i - 1);
            Quick_Sort_Ascending(unsortedList, j + 1, right);
        }
    }



    public static void Quick_Sort_Descending(List<int> unsortedList, int left, int right)
    {
        //If the left index is less than the right, the sort is not yet complete
        if (left < right)
        {
            int middle = unsortedList[(left + right) / 2];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                while (unsortedList[++i] > middle && i < right)
                    ; 
                while (unsortedList[--j] < middle && j > 0)
                    ; 

                if (i >= j)
                    break;

                (unsortedList[i], unsortedList[j]) = (unsortedList[j], unsortedList[i]);
            }

            Quick_Sort_Descending(unsortedList, left, i - 1);
            Quick_Sort_Descending(unsortedList, j + 1, right);
        }
    }
}