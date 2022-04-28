namespace Assignment;

public class ReadFile
{
    // method to read a text file and store the contents into an integer list
    public static List<int> Read_File(string filename)
    {
        // read file from the directory "Files GO Here" and storing them as a string array
        string[] strList = File.ReadAllLines("Files Go HERE/" + filename);
        
        // integer list to hold the contents of the file
        List<int> intList = new List<int>();

        // converting the items of the string array to integer and storing the contents into 'intList'
        foreach (string num in strList)
        {
            intList.Add(Int32.Parse(num));
        }

        return intList;
    }

    // print out the values from the list of integers
    public static void Get_Value(List<int> list)
    {
        // a list to hold either every 10th or every 50th value
        List<int> values = new List<int>();

        // check the length of the list
        if (list.Count <= 256)
        {
            Console.WriteLine("Displaying every 10th item:");
            // increment i by 10 to get every tenth value
            for (int i = 0; i < list.Count; i = i + 10)
            {
                values.Add(list[i]);
            }
        }
        else if (list.Count > 256)
        {
            Console.WriteLine("Displaying every 50th item:");
            // increment i by 10 to get every fiftieth value
            for (int i = 0; i < list.Count; i = i + 50)
            {
                values.Add(list[i]);
            }
        }
        // printing the values of the list
        foreach (int value in values)
        {
            Console.Write(value + " ");
        }
    }

}
