using Tyuiu.GoryaevTT.Sprint5.Task7.V21.Lib;
namespace Tyuiu.GoryaevTT.Sprint5.Task7.V21
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V21.txt";
            Class1 ds = new Class1();
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(res);
        }
    }
}