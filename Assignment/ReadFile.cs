namespace Assignment;

public class ReadFile
{
    public static List<int> Read_File(string filename)
    {
        string[] strList = File.ReadAllLines("../Files Go HERE/" + filename);
        List<int> intList = new List<int>();

        foreach (string num in strList)
        {
            intList.Add(Int32.Parse(num));
        }

        return intList;
    }
}

// string[] strShare_1_256 = File.ReadAllLines("../Files Go HERE/Share_1_256.txt");
// string[] strShare_2_256 = File.ReadAllLines("../Files Go HERE/Share_2_256.txt");
// string[] strShare_3_256= File.ReadAllLines("../Files Go HERE/Share_3_256.txt");

// string[] strShare_1_2048 = File.ReadAllLines("../Files Go HERE/Share_1_2048.txt");
// string[] strShare_2_2048 = File.ReadAllLines("../Files Go HERE/Share_2_2048.txt");
// string[] strShare_3_2048 = File.ReadAllLines("../Files Go HERE/Share_3_2048.txt");


// // Initialize a new integer list to hold the contents of the file in integer form
// List<int> intShare_1_256 = new List<int>();
// List<int> intShare_2_256 = new List<int>();
// List<int> intShare_3_256 = new List<int>();

// List<int> intShare_1_2048 = new List<int>();
// List<int> intShare_2_2048 = new List<int>();

