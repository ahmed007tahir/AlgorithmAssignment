using Assignment;


// TASK 1: Read individual files into arrays
List<int> intShare_1_256 = ReadFile.Read_File("Share_1_256.txt");
List<int> intShare_2_256 = ReadFile.Read_File("Share_2_256.txt");
List<int> intShare_3_256 = ReadFile.Read_File("Share_3_256.txt");
List<int> intShare_1_2048 = ReadFile.Read_File("Share_1_2048.txt");
List<int> intShare_2_2048 = ReadFile.Read_File("Share_2_2048.txt");
List<int> intShare_3_2048 = ReadFile.Read_File("Share_3_2048.txt");



int counter = 0;
// // iterate through the strNumber list and assign each value to the list integerNumber
// foreach (string num in strNumbers1)
// {
//     integerNumbers1.Add(Int32.Parse(num));
// }

// foreach (string num in strNumbers2)
// {
//     integerNumbers2.Add(Int32.Parse(num));
// }

// foreach (string num in strNumbers3)
// {
//     integerNumbers3.Add(Int32.Parse(num));
// }

//  ///////////////////////////////////////////////////////////////////////////////////////////
 
//  foreach (int num in integerNumbers1)
//  {
//      Console.Write(num + " ");
//  }

//  Console.WriteLine("\n");

//  QuickSort.Quick_Sort_Descending(integerNumbers1,0,integerNumbers1.Count-1);


 foreach (int num in intShare_1_256)
 {
    Console.Write(num + "(" + counter + ") ");
    counter++;
 }

// Console.WriteLine("\n");

// Console.WriteLine(LinearSearch.Linear_Search(integerNumbers1, 32));
// Console.WriteLine(BinarySearch.Binary_Search(integerNumbers1, 105));

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