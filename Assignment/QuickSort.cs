namespace Assignment;

public class QuickSort
{
    public static void Quick_Sort(List<int> list, int left, int right) 
        {
            if (left < right)
            {
                int pivot = Partition(list, left, right);

                if (pivot > 1) {
                    Quick_Sort(list, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    Quick_Sort(list, pivot + 1, right);
                }
            }
        
        }

        private static int Partition(List<int> list, int left, int right)
        {
            int pivot = list[left];
            while (true) 
            {

                while (list[left] < pivot) 
                {
                    left++;
                }

                while (list[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (list[left] == list[right]) return right;

                    int temp = list[left];
                    list[left] = list[right];
                    list[right] = temp;
                }
                else 
                {
                    return right;
                }
            }
        }
}