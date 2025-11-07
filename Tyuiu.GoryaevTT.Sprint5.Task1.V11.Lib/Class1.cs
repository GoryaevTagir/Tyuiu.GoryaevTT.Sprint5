using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GoryaevTT.Sprint5.Task1.V11.Lib
{
    public class Class1 : ISprint5Task1V11
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fl = new FileInfo(path);
            if (fl.Exists )
            {
                File.Delete(path);
            }
            double y;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - 3 * x + 2, 2);
                if (x != stopValue)
                {
                    File.AppendAllText(path, Convert.ToString(y) + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, Convert.ToString(y));
                }
            }
            return path;
        }
    }
}
