using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GoryaevTT.Sprint5.Task6.V8.Lib
{
    public class Class1 : ISprint5Task6V8
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string[] words = File.ReadAllText(path).Split(" ");
            foreach (string word in words)
            {
                if ( word.Length == 2 )
                {
                    count++;
                }
            }
            return count;
        }
    }
}
