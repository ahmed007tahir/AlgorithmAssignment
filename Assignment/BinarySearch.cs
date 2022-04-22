using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BinarySearch
    {
        public static int Binary_Search(List<int> list, int value)
        {
            int lowerBound = 0;
            int upperBound = list.Count-1;
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
                else return midPoint;
            }
            return midPoint;
        }
    }
}
