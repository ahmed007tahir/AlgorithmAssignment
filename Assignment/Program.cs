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
    while (true)
    {
        Console.Write(@"

        Please pick an option:

           a) Sort      b) Search      x) EXIT Program
      
        Your Response: ");

        string searchOrSort = Console.ReadLine();

        while (true)
        {
            if (searchOrSort == "a")
            {
                while (true)
                {
                    Console.Write(@"
       

           Please choose the file you wish to sort:

           a) Share_1_256.txt      d) Share_1_2048.txt       g) Share_1_256 & Share_3_256
           b) Share_2_256.txt      e) Share_2_2048.txt       h) Share_1_2048 & Share_3_2048
           c) Share_3_256.txt      f) Share_3_2048.txt       x) Exit Program

        Your Response: ");

                    string file_choice = Console.ReadLine();

                    if (file_choice == "a") {list = intShare_1_256;break;}
                    if (file_choice == "b") {list = intShare_2_256; break;}
                    if (file_choice == "c") {list = intShare_3_256; break;}
                    if (file_choice == "d") {list = intShare_1_2048; break;}
                    if (file_choice == "e") {list = intShare_2_2048; break;}
                    if (file_choice == "f") {list = intShare_3_2048; break;}
                    if (file_choice == "g") {list = task7part1; break;}
                    if (file_choice == "h") {list = task7part2; break;}
                    if (file_choice == "x") Environment.Exit(0);
                    else Console.WriteLine("Invalid Input! Please try again!");
                }
                Console.WriteLine(@"
 █▀█ █▀█ █ █▀▀ █ █▄░█ ▄▀█ █░░   █░░ █ █▀ ▀█▀ ▀
 █▄█ █▀▄ █ █▄█ █ █░▀█ █▀█ █▄▄   █▄▄ █ ▄█ ░█░ ▄:
");
                ReadFile.Get_Value(list);
                Console.WriteLine(
                    "\n\n========================================================================================================");

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
                Console.WriteLine(
                    "\n\n========================================================================================================");

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
                Console.WriteLine(
                    "\n\n=======================================================================================================");

                Console.WriteLine(@"
        
 █▀▄▀█ █▀▀ █▀█ █▀▀ █▀▀   █▀ █▀█ █▀█ ▀█▀   ▄▀█ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 █░▀░█ ██▄ █▀▄ █▄█ ██▄   ▄█ █▄█ █▀▄ ░█░   █▀█ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
                ReadFile.Get_Value(MergeSort.MergeSortAscending(list));
                Console.WriteLine("\nThe Merge sort arranged the list in Ascending order in " + Counter.MergeSortAscending + " steps.");

                Console.WriteLine(@"
     

 █▀▄▀█ █▀▀ █▀█ █▀▀ █▀▀   █▀ █▀█ █▀█ ▀█▀   █▀▄ █▀▀ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 █░▀░█ ██▄ █▀▄ █▄█ ██▄   ▄█ █▄█ █▀▄ ░█░   █▄▀ ██▄ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
                int counterDescendingMergeSort = 0;
                ReadFile.Get_Value(MergeSort.MergeSortDescending(list));
                Console.WriteLine("\nThe Merge sort arranged the list in Descending order in " + Counter.MergeSortDescending + " steps.");

                Console.WriteLine(
                    "\n\n========================================================================================================");

                Console.WriteLine(@"
        
 █▀█ █░█ █ █▀▀ █▄▀   █▀ █▀█ █▀█ ▀█▀   ▄▀█ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 ▀▀█ █▄█ █ █▄▄ █░█   ▄█ █▄█ █▀▄ ░█░   █▀█ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");

                QuickSort.Quick_Sort_Ascending(list, 0, list.Count - 1);
                ReadFile.Get_Value(list);
                Console.WriteLine("\nThe Quick sort arranged the list in Ascending order in " + Counter.QuickSortAscending + " steps.");


                Console.WriteLine(@"
     

 █▀█ █░█ █ █▀▀ █▄▀   █▀ █▀█ █▀█ ▀█▀   █▀▄ █▀▀ █▀ █▀▀ █▀▀ █▄░█ █▀▄ █ █▄░█ █▀▀ ▀
 ▀▀█ █▄█ █ █▄▄ █░█   ▄█ █▄█ █▀▄ ░█░   █▄▀ ██▄ ▄█ █▄▄ ██▄ █░▀█ █▄▀ █ █░▀█ █▄█ ▄
");
                QuickSort.Quick_Sort_Descending(list, 0, list.Count - 1);
                ReadFile.Get_Value(list);
                Console.WriteLine("\nThe Quick sort arranged the list in Descending order in " + Counter.QuickSortDescending + " steps.");
                Console.WriteLine(
                    "\n\n========================================================================================================");
                break;
            }

            if (searchOrSort == "b")
            {
                while (true)
                {

                    Console.Write(@"
   

       Please choose the file you wish to search:

       a) Share_1_256.txt      d) Share_1_2048.txt       g) Share_1_256 & Share_3_256
       b) Share_2_256.txt      e) Share_2_2048.txt       h) Share_1_2048 & Share_3_2048
       c) Share_3_256.txt      f) Share_3_2048.txt       x) EXIT Program

    Your Response: ");

                    string file_choice = Console.ReadLine();

                    if (file_choice == "a") {list = intShare_1_256;break;}
                    else if (file_choice == "b")
                    {
                        list = intShare_2_256;
                        break;
                    }
                    else if (file_choice == "c")
                    {
                        list = intShare_3_256;
                        break;
                    }
                    else if (file_choice == "d")
                    {
                        list = intShare_1_2048;
                        break;
                    }
                    else if (file_choice == "e")
                    {
                        list = intShare_2_2048;
                        break;
                    }
                    else if (file_choice == "f")
                    {
                        list = intShare_3_2048;
                        break;
                    }
                    else if (file_choice == "g")
                    {
                        list = task7part1;
                        break;
                    }
                    else if (file_choice == "h")
                    {
                        list = task7part2;
                        break;
                    }
                    else if (file_choice == "x") Environment.Exit(0);
                    else
                    {
                        Console.WriteLine("Please try again!");
                    }
                }

                while (true)
                {
                    Console.Write("\nPlease enter a value u wish to search: ");
                    string input = Console.ReadLine();
                    int number;
                    Int32.TryParse(input, out number);
                    if (!Int32.TryParse(input, out number))
                    {
                        Console.WriteLine("Invalid Input! Please Insert an Integer value!");
                    }

                    List<int> sortedList = list.ToList();
                    sortedList = MergeSort.MergeSortAscending(list);

                    Console.WriteLine(@"

█▀ █▀█ █▀█ ▀█▀ █▀▀ █▀▄   █░░ █ █▀ ▀█▀
▄█ █▄█ █▀▄ ░█░ ██▄ █▄▀   █▄▄ █ ▄█ ░█░
");
                    int indexcounter = 0;
                    foreach (int num in sortedList)
                    {
                        Console.Write(num + "[" + indexcounter + "] ");
                        indexcounter++;
                    }

                    Console.WriteLine(@"

 █░░ █ █▄░█ █▀▀ ▄▀█ █▀█   █▀ █▀▀ ▄▀█ █▀█ █▀▀ █░█
 █▄▄ █ █░▀█ ██▄ █▀█ █▀▄   ▄█ ██▄ █▀█ █▀▄ █▄▄ █▀█
");
                    LinearSearch.Linear_Search(sortedList, number);

                    Console.WriteLine(@"


 █▄▄ █ █▄░█ ▄▀█ █▀█ █▄█   █▀ █▀▀ ▄▀█ █▀█ █▀▀ █░█
 █▄█ █ █░▀█ █▀█ █▀▄ ░█░   ▄█ ██▄ █▀█ █▀▄ █▄▄ █▀█
");

                    BinarySearch.Binary_Search(sortedList, number);
                    break;
                }


            }
            else if (searchOrSort == "x")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Input! Please try again!");
                break;
            }
        }
    }
}

