using Assignment;


// TASK 1: Read individual files into arrays
List<int> intShare_1_256 = ReadFile.Read_File("Share_1_256.txt");
List<int> intShare_2_256 = ReadFile.Read_File("Share_2_256.txt");
List<int> intShare_3_256 = ReadFile.Read_File("Share_3_256.txt");
List<int> intShare_1_2048 = ReadFile.Read_File("Share_1_2048.txt");
List<int> intShare_2_2048 = ReadFile.Read_File("Share_2_2048.txt");
List<int> intShare_3_2048 = ReadFile.Read_File("Share_3_2048.txt");

while (true)
{
    

    Console.WriteLine(@"
    Please choose the file you wish to search:
    a) Share_1_256.txt      d) Share_1_2048.txt
    b) Share_2_256.txt      e) Share_2_2048.txt
    c) Share_3_256.txt      f) Share_3_2048.txt

    Your Response: ");

    string user_input = Console.ReadLine();

    switch (user_input)
    {
        case "a":
        {
            Console.WriteLine("You picked a");
            break;
        }
        case "b":
        {
            Console.WriteLine("You picked b");
            break;
        }
        case "c":
        {
            Console.WriteLine("You picked c");
            break;
        }
        case "d":
        {
            Console.WriteLine("You picked d");
            break;
        }
        case "e":
        {
            Console.WriteLine("You picked e");
            break;
        }
        case "f":
        {
            Console.WriteLine("You picked f");
            break;
        }
        default:
        {
            Console.WriteLine("Please try again!");
            break;
        }
    }
}