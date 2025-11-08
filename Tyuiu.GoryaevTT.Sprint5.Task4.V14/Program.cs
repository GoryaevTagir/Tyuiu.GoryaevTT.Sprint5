using Tyuiu.GoryaevTT.Sprint5.Task4.V14.Lib;
namespace Tyuiu.GoryaevTT.Sprint5.Task4.V14
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            string path = @"C:\DataSprint5\InPutDataFileTask4V14.txt";
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}