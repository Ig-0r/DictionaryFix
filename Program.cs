using DictionaryFix.Entities;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter full file path: ");
        string path = Console.ReadLine();

        Dictionary<string, int> votesInfo = new Dictionary<string, int>();

        CSVinfo fileInfo = new CSVinfo(path);

        try
        {
            using (StreamReader sr = File.OpenText(fileInfo.Path))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    fileInfo.Name = line[0];
                    fileInfo.Votes = int.Parse(line[1]);
                    if (votesInfo.ContainsKey(fileInfo.Name))
                    {
                        votesInfo[fileInfo.Name] += fileInfo.Votes;
                    }
                    else
                    {
                        votesInfo[fileInfo.Name] = fileInfo.Votes;
                    }
                }

                foreach (KeyValuePair<string, int> obj in votesInfo)
                {
                    Console.WriteLine(obj.Key + ": " + obj.Value);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}