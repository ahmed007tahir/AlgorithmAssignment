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
            List<int> list_ascending = ReadFile.Get_Value(list);
            foreach (var item in list_ascending)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            BubbleSort.BubbleSortDescending(list);
            List<int> list_descending = ReadFile.Get_Value(list);
            foreach (var item in list_descending)
            {
                Console.Write(item + " ");
            }
            break;
        }
        case "b":
        {
            List<int> list_ascending = InsertionSort.InsertionSortAscending(list);
            list_ascending = ReadFile.Get_Value(list);
            foreach (var item in list_ascending)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            List<int> list_descending = InsertionSort.InsertionSortDescending(list);
            list_descending = ReadFile.Get_Value(list);
            foreach (var item in list_descending)
            {
                Console.Write(item + " ");
            }
            break;
        }
        case "c":
        {
            List<int> list_ascending = MergeSort.MergeSortAscending(list);
            list_ascending = ReadFile.Get_Value(list);
            foreach (var item in list_ascending)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            List<int> list_descending = MergeSort.MergeSortDescending(list);
            list_descending = ReadFile.Get_Value(list);
            foreach (var item in list_descending)
            {
                Console.Write(item + " ");
            }
            break;
        }
        case "d":
        {
            QuickSort.Quick_Sort_Ascending(list,0,list.Count-1);
            List<int> list_ascending = ReadFile.Get_Value(list);
            foreach (var item in list_ascending)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            QuickSort.Quick_Sort_Descending(list,0,list.Count-1);
            List<int> list_descending = ReadFile.Get_Value(list);
            foreach (var item in list_descending)
            {
                Console.Write(item + " ");
            }
            break;
        }
        case "e":
        {
            int counter = 0;

            foreach (var i in list)
            {
                Console.Write(i + "(" + counter + ") ");
                counter++;
            }
            Console.Write("Type in the value: ");
            int value = Int32.Parse(Console.ReadLine());
            LinearSearch.Linear_Search(list, value);
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