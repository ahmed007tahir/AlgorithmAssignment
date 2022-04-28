namespace Assignment
{
    internal class BinarySearch
    {
        // This method takes in two arguments: an integer list & a integer 'value' and prints out the index of the value within the list.
        // Binary Search allows us to search an element in a given list of sorted elements. Binary Search reduces the size of data set to searched by half at each step.
        // Binary search follows the divide and conquer approach in which the list is divided into two halves, and the item is compared with the middle element of the list.
        // If the match is found then, the location of the middle element is returned.
        // Otherwise, we search into either of the halves depending upon the result produced through the match.
        public static void Binary_Search(List<int> list, int value)
        {
            int lowerBound = 0;
            int upperBound = list.Count - 1;
            int midPoint = 0;

            // This variable keeps track of the number of steps taken by the program
            int counter = 0;

            // this loop will run until the lower and upper bound are adjacent items within the list,
            // by the end of this while loop, the midpoint will either hold the value requested by the user (if it exits with in the list),
            // or the midpoint will hold the item closest in value to the number requested by the user (if the item does not exist within the list)
            while (lowerBound <= upperBound)
            {
                counter++;
                // at each iteration, the new midpoint is calculated using the new lower and upper bound values
                midPoint = (lowerBound + upperBound) / 2;

                // this statements sets the new value of the upper bound
                if (value < list[midPoint])
                {
                    upperBound = midPoint - 1;
                }
                // this statements sets the new value of the lower bound
                else if (value > list[midPoint])
                {
                    lowerBound = midPoint + 1;
                }
                else break;
            }

            // the statement checks to see if the midpoint matches the value requested by the user (hence whether the item exists with in the list or not)
            // in the case the value does not match, the user is given an error message informing them that the item does not exist with in the list, and the
            // value and the index of the midpoint (which holds the next closest value) is printed off instead
            if (list[midPoint] != value)
            {
                Console.WriteLine("The number " + value + " does not exist within the list! The next closest number is " + list[midPoint] + " at index " + midPoint);
                Console.WriteLine("This algorithm sorted the list in " + counter + " steps.");
            }
            else
            {
                // in the case of the value being within the list, these for loops check to see if the adjacent elements of the list contain the same items
                // since the list needs to be sorted prior to using the binary search method, the values can only exist next to each other.
                Console.Write("The value " + value + " occurs at index ");
                for (int i = midPoint - 1; list[i] == list[midPoint]; i--)
                {
                    Console.Write(i + " ");
                }
                Console.Write(midPoint + " ");
                for (int i = midPoint + 1; list[i] == list[midPoint]; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\nIt took this algorithm " + counter + " steps to search through the list.");

            }
        }
    }
}
