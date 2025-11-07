using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GoryaevTT.Sprint5.Task0.V22.Lib
{
    public class Class1 : ISprint5Task0V22
    {
        public string SaveToFileTextData(int x)
        {
            string way = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double res = Math.Round(Math.Pow(1 - x, 2) / (-3 * x), 3);
            File.WriteAllText(way, Convert.ToString(res));
            return way;
        }
    }
}
