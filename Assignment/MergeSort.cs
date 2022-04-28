using System.Diagnostics.Metrics;

namespace Assignment;

public class MergeSort
{
    public static List<int> MergeSortAscending(List<int> list)
    {
        if (list.Count <= 1) //defining the base case
        {
            return list;
        }

        // Recursive case. First, divide the list into equal-sized sub-lists
        // consisting of the first half and second half of the list.
        List<int> leftSide = new List<int>(); //to hold the first half of the list
        List<int> rightSide = new List<int>(); //to hold the second half of the list

        for (int i = 0; i < list.Count; i++)
        {
            Counter.MergeSortAscending++;
            if (i < list.Count / 2)
            {
                leftSide.Add(list[i]);
            }
            else
            {
                rightSide.Add(list[i]);
            }
        }
        // Recursively sort both sub-lists
        leftSide = MergeSortAscending(leftSide);
        rightSide = MergeSortAscending(rightSide);
        // Then merge the now-sorted sub-lists
        return MergeAscending(leftSide, rightSide);
    }

    private static List<int>  MergeAscending(List<int> leftSide, List<int> rightSide)
    {
        List<int> result = new List<int>();

        while (leftSide.Count > 0 && rightSide.Count > 0)
        {
            Counter.MergeSortAscending++;
            if (leftSide[0] <= rightSide[0])
            {
                result.Add(leftSide[0]);
                leftSide.RemoveAt(0);
            }
            else
            {
                result.Add(rightSide[0]);
                rightSide.RemoveAt(0);
            }
        }

        // Either left or right may have elements left; consume them.
        // (Only one of the following loops will actually be entered.)

        while (leftSide.Count > 0)
        {
            Counter.MergeSortAscending++;
            result.Add(leftSide[0]);
            leftSide.RemoveAt(0);
        }
        while (rightSide.Count > 0)
        {
            Counter.MergeSortAscending++;
            result.Add(rightSide[0]);
            rightSide.RemoveAt(0);
        }
        return result;
    }
    
    public static List<int> MergeSortDescending(List<int> list)
    {
        if (list.Count <= 1) //base case
        {
            return list;
        }
        // Recursive case. First, divide the list into equal-sized sublists
        // consisting of the first half and second half of the list.
        // This assumes lists start at index 0.

        List<int> leftSide = new List<int>();
        List<int> rightSide = new List<int>();

        for (int i = 0; i < list.Count; i++)
        {
            Counter.MergeSortDescending++;
            if (i < list.Count / 2)
            {
                leftSide.Add(list[i]);
            }
            else
            {
                rightSide.Add(list[i]);
            }
        }
        // Recursively sort both sublists
        leftSide = MergeSortDescending(leftSide);
        rightSide = MergeSortDescending(rightSide);
        

        // Then merge the now-sorted sublists
        return MergeDescending(leftSide, rightSide);

    }

    private static List<int> MergeDescending(List<int> leftSide, List<int> rightSide)
    {
        List<int> result = new List<int>();

        while (leftSide.Count > 0 && rightSide.Count > 0)
        {
            Counter.MergeSortDescending++;
            if (leftSide[0] >= rightSide[0])
            {
                result.Add(leftSide[0]);
                leftSide.RemoveAt(0);
            }
            else
            {
                result.Add(rightSide[0]);
                rightSide.RemoveAt(0);
            }
        }

        // Either left or right may have elements left; consume them.
        // (Only one of the following loops will actually be entered.)

        while (leftSide.Count > 0)
        {
            Counter.MergeSortDescending++;
            result.Add(leftSide[0]);
            leftSide.RemoveAt(0);
        }
        while (rightSide.Count > 0)
        {
            Counter.MergeSortDescending++;
            result.Add(rightSide[0]);
            rightSide.RemoveAt(0);
        }
        return result;
    }
}