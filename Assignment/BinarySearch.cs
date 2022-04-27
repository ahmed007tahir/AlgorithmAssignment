namespace Assignment
{
    internal class BinarySearch
    {
        public static void Binary_Search(List<int> list, int value)
        {
            int index;
            int lowerBound = 0;
            int upperBound = list.Count - 1;
            int midPoint = 0;

            while (lowerBound <= upperBound)
            {
                midPoint = (lowerBound + upperBound) / 2;
                if (value < list[midPoint])
                {
                    upperBound = midPoint - 1;
                }
                else if (value > list[midPoint])
                {
                    lowerBound = midPoint + 1;
                }
                else
                {
                    index = midPoint;
                    break;
                }
            }

            if (list[midPoint] != value)
            {
                Console.WriteLine("The number " + value + " does not exist within the list! The next closest number is " + list[midPoint] + " at index " + midPoint);
            }
            else
            {
                Console.Write("The value " + value + " occurs at index ");
                for (int i = midPoint; list[i] == list[midPoint]; i--)
                {
                    Console.Write(i + " ");
                }
                for (int i = midPoint; list[i] == list[midPoint]; i++)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
