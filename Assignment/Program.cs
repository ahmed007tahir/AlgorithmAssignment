using Assignment;


// TASK 1: Read individual files into arrays
List<int> intShare_1_256 = ReadFile.Read_File("Share_1_256.txt");
List<int> intShare_2_256 = ReadFile.Read_File("Share_2_256.txt");
List<int> intShare_3_256 = ReadFile.Read_File("Share_3_256.txt");
List<int> intShare_1_2048 = ReadFile.Read_File("Share_1_2048.txt");
List<int> intShare_2_2048 = ReadFile.Read_File("Share_2_2048.txt");
List<int> intShare_3_2048 = ReadFile.Read_File("Share_3_2048.txt");

List<int> list = new List<int>{};

// get the user to choose the file
while (true)
{
    Console.WriteLine(@"
    Please choose the file you wish to search:
    a) Share_1_256.txt      d) Share_1_2048.txt
    b) Share_2_256.txt      e) Share_2_2048.txt
    c) Share_3_256.txt      f) Share_3_2048.txt

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
        default:
        {
            Console.WriteLine("Please try again!");
            break;
        }
    }

while (true)
{
    Console.Write(@"
    Please choose which algorithm you wish to use:
    a) Bubble Sort           d) Quick Sort
    b) Insertion Sort        e) Linear Search
    c) Merge Sort            f) Binary Search

    Your Response: ");

    string algorithm_choice = Console.ReadLine();

    switch (algorithm_choice)
    {
        case "a":
        {
            BubbleSort.BubbleSortAscending(list);
            List<int> somelist = ReadFile.Get_Value(list);
            foreach (var item in somelist)
            {
                Console.Write(item + " ");
            }
            break;
        }
        case "b":
        {
            List<int> somelist = InsertionSort.InsertionSortAscending(list);
            somelist = ReadFile.Get_Value(list);
            foreach (var item in somelist)
            {
                Console.Write(item + " ");
            }
            break;
        }
        case "c":
        {
            List<int> somelist = MergeSort.MergeSortAscending(list);
            somelist = ReadFile.Get_Value(list);
            foreach (var item in somelist)
            {
                Console.Write(item + " ");
            }
            break;
        }
        case "d":
        {
            QuickSort.Quick_Sort_Ascending(list,0,list.Count-1);
            List<int> somelist = ReadFile.Get_Value(list);
            foreach (var item in somelist)
            {
                Console.Write(item + " ");
            }
            break;
        }
        case "e":
        {
            break;
        }
        case "f":
        {
            break;
        }
        default:
        {
            Console.WriteLine("Please try again!");
            break;
        }
    }


}
}