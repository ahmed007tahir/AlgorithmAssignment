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

Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░████████╗  ███╗░░██╗  ░██████╗███████╗░█████╗░██████╗░░█████╗░██╗░░██╗
    ██╔════╝██╔══██╗██╔══██╗╚══██╔══╝  ████╗░██║  ██╔════╝██╔════╝██╔══██╗██╔══██╗██╔══██╗██║░░██║
    ╚█████╗░██║░░██║██████╔╝░░░██║░░░  ██╔██╗██║  ╚█████╗░█████╗░░███████║██████╔╝██║░░╚═╝███████║
    ░╚═══██╗██║░░██║██╔══██╗░░░██║░░░  ██║╚████║  ░╚═══██╗██╔══╝░░██╔══██║██╔══██╗██║░░██╗██╔══██║
    ██████╔╝╚█████╔╝██║░░██║░░░██║░░░  ██║░╚███║  ██████╔╝███████╗██║░░██║██║░░██║╚█████╔╝██║░░██║
    ╚═════╝░░╚════╝░╚═╝░░╚═╝░░░╚═╝░░░  ╚═╝░░╚══╝  ╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝");
while (true)
{
    Console.Write(@"

    Please choose the file you wish to search:

       a) Share_1_256.txt      d) Share_1_2048.txt       g) Share_1_256 & Share_3_256
       b) Share_2_256.txt      e) Share_2_2048.txt       h) Share_1_2048 & Share_3_2048
       c) Share_3_256.txt      f) Share_3_2048.txt       x) EXIT Program

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
        case "g":
            {
                list = task7part1;
                break;
            }
        case "h":
            {
                list = task7part2;
                break;
            }
        case "x":
        {
            Environment.Exit(0);
            break;
        }
        default:
            {
                Console.WriteLine("Please try again!");
                break;
            }
    }

    // list = MergeSort.MergeSortAscending(list);
    //
    // int index = 0;
    // foreach (int item in list)
    // {
    //     Console.Write(item + "(" + index + ") ");
    //     index++;
    // }
    // BinarySearch.Binary_Search(list,7);

    // list = BubbleSort.BubbleSortAscending(list);

    // int index = 0;
    // foreach (int item in list)
    // {
    //     Console.Write(item + "(" + index + ") ");
    //     index++;

    // }

    // BinarySearch.Binary_Search(list, 7);

    Console.WriteLine(@"
    █▀█ █▀█ █ █▀▀ █ █▄░█ ▄▀█ █░░   █░░ █ █▀ ▀█▀ ▀
    █▄█ █▀▄ █ █▄█ █ █░▀█ █▀█ █▄▄   █▄▄ █ ▄█ ░█░ ▄:
");
    ReadFile.Get_Value(list);
    Console.WriteLine("\n\n========================================================================================================");

    Console.WriteLine(@"
 █▄▄ █░█ █▄▄ █▄▄ █░░ █▀▀   █▀ █▀█ █▀█ ▀█▀   ▄▀█ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 █▄█ █▄█ █▄█ █▄█ █▄▄ ██▄   ▄█ █▄█ █▀▄ ░█░   █▀█ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
    ReadFile.Get_Value(BubbleSort.BubbleSortAscending(list));

    Console.WriteLine(@"
        
 █▄▄ █░█ █▄▄ █▄▄ █░░ █▀▀   █▀ █▀█ █▀█ ▀█▀   █▀▄ █▀▀ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 █▄█ █▄█ █▄█ █▄█ █▄▄ ██▄   ▄█ █▄█ █▀▄ ░█░   █▄▀ ██▄ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
    ReadFile.Get_Value(BubbleSort.BubbleSortDescending(list));
    Console.WriteLine("\n\n========================================================================================================");

    Console.WriteLine(@"
        
 █ █▄░█ █▀ █▀▀ █▀█ ▀█▀ █ █▀█ █▄░█   █▀ █▀█ █▀█ ▀█▀   ▄▀█ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 █ █░▀█ ▄█ ██▄ █▀▄ ░█░ █ █▄█ █░▀█   ▄█ █▄█ █▀▄ ░█░   █▀█ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
    ReadFile.Get_Value(InsertionSort.InsertionSortAscending(list));

    Console.WriteLine(@"
        
 █ █▄░█ █▀ █▀▀ █▀█ ▀█▀ █ █▀█ █▄░█   █▀ █▀█ █▀█ ▀█▀   █▀▄ █▀▀ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 █ █░▀█ ▄█ ██▄ █▀▄ ░█░ █ █▄█ █░▀█   ▄█ █▄█ █▀▄ ░█░   █▄▀ ██▄ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
    ReadFile.Get_Value(InsertionSort.InsertionSortDescending(list));
    Console.WriteLine("\n\n=======================================================================================================");

    Console.WriteLine(@"
        
 █▀▄▀█ █▀▀ █▀█ █▀▀ █▀▀   █▀ █▀█ █▀█ ▀█▀   ▄▀█ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 █░▀░█ ██▄ █▀▄ █▄█ ██▄   ▄█ █▄█ █▀▄ ░█░   █▀█ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
    ReadFile.Get_Value(MergeSort.MergeSortAscending(list));

    Console.WriteLine(@"
        
 █▀▄▀█ █▀▀ █▀█ █▀▀ █▀▀   █▀ █▀█ █▀█ ▀█▀   █▀▄ █▀▀ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 █░▀░█ ██▄ █▀▄ █▄█ ██▄   ▄█ █▄█ █▀▄ ░█░   █▄▀ ██▄ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
    ReadFile.Get_Value(MergeSort.MergeSortDescending(list));
    Console.WriteLine("\n\n========================================================================================================");

    Console.WriteLine(@"
        
 █▀█ █░█ █ █▀▀ █▄▀   █▀ █▀█ █▀█ ▀█▀   ▄▀█ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 ▀▀█ █▄█ █ █▄▄ █░█   ▄█ █▄█ █▀▄ ░█░   █▀█ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
    QuickSort.Quick_Sort_Ascending(list, 0, list.Count - 1);
    ReadFile.Get_Value(list);

    Console.WriteLine(@"
        
 █▀█ █░█ █ █▀▀ █▄▀   █▀ █▀█ █▀█ ▀█▀   █▀▄ █▀▀ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 ▀▀█ █▄█ █ █▄▄ █░█   ▄█ █▄█ █▀▄ ░█░   █▄▀ ██▄ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
    QuickSort.Quick_Sort_Descending(list, 0, list.Count - 1);
    ReadFile.Get_Value(list);
    Console.WriteLine("\n\n========================================================================================================");

}
