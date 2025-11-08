using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GoryaevTT.Sprint5.Task4.V14.Lib
{
    public class Class1 : ISprint5Task4V14
    {
        public double LoadFromDataFile(string path)
        {
            foreach (string el in File.ReadAllLines(path))
            {
                if (el == ".")
                {
                    File.ReadAllText(path).Replace(".", ",");
                }
            }
            double x = Convert.ToDouble(File.ReadAllText(path));
            double res = Math.Round(Math.Sin(Math.Pow(x, 3)) + 2 / x, 3);
            return res;
        }
    }
}
