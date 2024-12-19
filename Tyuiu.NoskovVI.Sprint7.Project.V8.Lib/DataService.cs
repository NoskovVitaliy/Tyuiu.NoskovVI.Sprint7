namespace Tyuiu.NoskovVI.Sprint7.Project.V8.Lib
{
    public class DataService
    {
        public List<string[]> LoadDataFromFile(string path)
        {
            string line = File.ReadAllText(path).Replace('\n', '\r');
            string[] lines = line.Split('\r', StringSplitOptions.RemoveEmptyEntries);
            List<string[]> strings = new List<string[]>();
            for (int i = 0; i < lines.Length; i++)
            {
                strings.Add(lines[i].Split(';'));
                
            }
            return strings;
            
        }
    }
}
