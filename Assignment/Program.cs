
// make this more efficient plz

// try converting the integers straight to int[] while reading the file


// Store the contents of 'File' into string[] strNumber

using Assignment;

string[] strNumbers1 = File.ReadAllLines("../Files Go HERE/Share_1_256.txt");
string[] strNumbers2 = File.ReadAllLines("../Files Go HERE/Share_2_256.txt");
string[] strNumbers3= File.ReadAllLines("../Files Go HERE/Share_3_256.txt");
// Initialize a new integer list to hold the contents of the file in integer form
List<int> integerNumbers1 = new List<int>();
List<int> integerNumbers2 = new List<int>();
List<int> integerNumbers3 = new List<int>();


int counter = 0;
// iterate through the strNumber list and assign each value to the list integerNumber
foreach (string num in strNumbers1)
{
    integerNumbers1.Add(Int32.Parse(num));
}

foreach (string num in strNumbers2)
{
    integerNumbers2.Add(Int32.Parse(num));
}

foreach (string num in strNumbers3)
{
    integerNumbers3.Add(Int32.Parse(num));
}

 ///////////////////////////////////////////////////////////////////////////////////////////
 
 foreach (int num in integerNumbers2)
 {
     Console.Write(num + " ");
 }

 Console.WriteLine("\n");

 QuickSort.Quick_Sort(integerNumbers1);

 foreach (int num in integerNumbers1)
 {
    Console.Write(num + "(" + counter + ") ");
    counter++;
 }

Console.WriteLine("\n");

Console.WriteLine(LinearSearch.Linear_Search(integerNumbers1, 78));
Console.WriteLine(BinarySearch.Binary_Search(integerNumbers1, 78));

///////////////////////////////////////////////////////////////////////////////////////////



// Console.WriteLine("\n");

// List<int> sorted2 = BubbleSort.BubbleSortDescending(integerNumbers2);

// foreach (int num in sorted2)
// {
//     Console.Write(num + " ");
// }

// ///////////////////////////////////////////////////////////////////////////////////////////

// Console.WriteLine("\n");

// List<int> sorted3 = InsertionSort.InsertionSortAscending(integerNumbers2);

// foreach (int num in sorted3)
// {
//     Console.Write(num + " ");
// }

// Console.WriteLine("\n");

// List<int> sorted4 = InsertionSort.InsertionSortDescending(integerNumbers2);

// foreach (int num in sorted4)
// {
//     Console.Write(num + " ");
// }

// ///////////////////////////////////////////////////////////////////////////////////////////

// Console.WriteLine("\n");

// List<int> sorted5 = MergeSort.MergeSortAscending(integerNumbers2);

// foreach (int num in sorted5)
// {
//     Console.Write(num + " ");
// }

// ///////////////////////////////////////////////////////////////////////////////////////////

// Console.WriteLine("\n");

// List<int> sorted6 = MergeSort.MergeSortDescending(integerNumbers2);

// foreach (int num in sorted6)
// {
//     Console.Write(num + " ");
// }

///////////////////////////////////////////////////////////////////////////////////////////

/*Console.WriteLine("\n");
Console.WriteLine(LinearSearch.Linear_Search(integerNumbers1,75));
*/