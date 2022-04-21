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
            int lowerBound = 1;
            int upperBound = list.Count;

            while (lowerBound <= upperBound)
            {
                int midPoint = (lowerBound + upperBound) / 2;
                if (list[midPoint] > value)
                {
                    upperBound = midPoint - 1;
                }
                else if (list[midPoint] < value)
                {
                    lowerBound = midPoint + 1;
                }
                else return midPoint;
            }
            // get it to return the closest element to the value
            return ;
        }
    }
}
