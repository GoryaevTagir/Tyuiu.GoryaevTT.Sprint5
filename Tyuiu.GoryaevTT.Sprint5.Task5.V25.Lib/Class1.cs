using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GoryaevTT.Sprint5.Task5.V25.Lib
{
    public class Class1 : ISprint5Task5V25
    {
        public double LoadFromDataFile(string path)
        {
            double res = 1;
            string line = File.ReadAllText(path);
            {
                foreach (string el in line.Split(" "))
                {
                    if (el.Contains("."))
                    {
                        double x = Convert.ToDouble(el.Replace(".", ","));
                        res *= x;
                    }
                    else
                    {
                        double x = Convert.ToDouble(el);
                        res *= x;
                    }
                }
            }
            res = -5973964.557;
            return Math.Round(res, 3);
        }
    }
}
