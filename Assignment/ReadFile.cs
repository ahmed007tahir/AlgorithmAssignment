namespace Assignment;

public class ReadFile
{
    public static List<int> Read_File(string filename)
    {
        string[] strList = File.ReadAllLines("Files Go HERE/" + filename);
        List<int> intList = new List<int>();

        foreach (string num in strList)
        {
            intList.Add(Int32.Parse(num));
        }

        return intList;
    }

    public static List<int> Get_Value(List<int> list)
    {
        List<int> values = new List<int>();

        if (list.Count == 256)
        {
            for(int i = 0; i < list.Count; i = i+10)
            {
                values.Add(list[i]);
            }
        }
        else if (list.Count == 2048)
        {
            for(int i = 0; i < list.Count; i = i+50)
            {
                values.Add(list[i]);
            }
        }
        return values;
    }

}
