using System.Diagnostics;
using Assignment;


// TASK 1: Read individual files into arrays
List<int> intShare_1_256 = ReadFile.Read_File("Share_1_256.txt");
List<int> intShare_2_256 = ReadFile.Read_File("Share_2_256.txt");
List<int> intShare_3_256 = ReadFile.Read_File("Share_3_256.txt");
List<int> intShare_1_2048 = ReadFile.Read_File("Share_1_2048.txt");
List<int> intShare_2_2048 = ReadFile.Read_File("Share_2_2048.txt");
List<int> intShare_3_2048 = ReadFile.Read_File("Share_3_2048.txt");
List<int> task7part1 = ReadFile.Read_File("Share_1_256 & Share_3_256.txt");
List<int> task7part2 = ReadFile.Read_File("Share_1_2048 & Share_3_2048.txt");

List<int> list = new List<int> { };

// get the user to choose the file
while (true)
{
    Console.Write(@"
    Please choose the file you wish to search:
       a) Share_1_256.txt      d) Share_1_2048.txt
       b) Share_2_256.txt      e) Share_2_2048.txt
       c) Share_3_256.txt      f) Share_3_2048.txt

       x) Share_1_256 & Share_3_256
       y) Share_1_2048 & Share_3_2048
    
    Your Response: ");

    string file_choice = Console.ReadLine();

    switch (file_choice)
    {
        case "a":
            {
                list = intShare_1_256;
                break;
            }
        case "b":
            {
                list = intShare_2_256;
                break;
            }
        case "c":
            {
                list = intShare_3_256;
                break;
            }
        case "d":
            {
                list = intShare_1_2048;
                break;
            }
        case "e":
            {
                list = intShare_2_2048;
                break;
            }
        case "f":
            {
                list = intShare_3_2048;
                break;
            }
        case "x":
            {
                list = task7part1;
                break;
            }
        case "y":
            {
                list = task7part2;
                break;
            }
        default:
            {
                Console.WriteLine("Please try again!");
                break;
            }
    }

    // list = InsertionSort.InsertionSortDescending(list);
    //
    // int index = 0;
    // foreach (int item in list)
    // {
    //     Console.Write(item + "(" + index + ") ");
    //     index++;
    //
    // }
    // BinarySearch.Binary_Search(list, 7);

    Console.WriteLine("\nOriginal List:");
    ReadFile.Get_Value(list);
    Console.WriteLine("\n----------------------------------------------------------------------------------------------------");

    Console.WriteLine("\n\nBubble Sort Ascending:");
    ReadFile.Get_Value(BubbleSort.BubbleSortAscending(list));

    Console.WriteLine("\n\nBubble Sort Descending:");
    ReadFile.Get_Value(BubbleSort.BubbleSortDescending(list));
    Console.WriteLine("\n----------------------------------------------------------------------------------------------------");

    Console.WriteLine("\n\n\nInsertion Sort Ascending:");
    ReadFile.Get_Value(InsertionSort.InsertionSortAscending(list));

    Console.WriteLine("\n\nInsertion Sort Descending:");
    ReadFile.Get_Value(InsertionSort.InsertionSortDescending(list));
    Console.WriteLine("\n----------------------------------------------------------------------------------------------------");

    Console.WriteLine("\n\n\nMerge Sort Ascending:");
    ReadFile.Get_Value(MergeSort.MergeSortAscending(list));

    Console.WriteLine("\n\nMerge Sort Descending:");
    ReadFile.Get_Value(MergeSort.MergeSortDescending(list));
    Console.WriteLine("\n----------------------------------------------------------------------------------------------------");

    Console.WriteLine("\n\n\nQuick Sort Ascending:");
    QuickSort.Quick_Sort_Ascending(list, 0, list.Count - 1);
    ReadFile.Get_Value(list);

    Console.WriteLine("\n\nQuick Sort Descending:");
    QuickSort.Quick_Sort_Descending(list, 0, list.Count - 1);
    ReadFile.Get_Value(list);
}
