using Tyuiu.GoryaevTT.Sprint5.Task6.V8.Lib;
namespace Tyuiu.GoryaevTT.Sprint5.Task6.V8
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V8.txt";
            Class1 ds = new Class1();
            int res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
        }
    }
}