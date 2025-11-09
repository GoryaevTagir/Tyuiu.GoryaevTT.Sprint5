using Tyuiu.GoryaevTT.Sprint5.Task5.V25.Lib;
namespace Tyuiu.GoryaevTT.Sprint5.Task5.V25
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V25.txt";
            Class1 ds = new Class1();
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}