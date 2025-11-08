using Tyuiu.GoryaevTT.Sprint5.Task3.V8.Lib;
namespace Tyuiu.GoryaevTT.Sprint5.Task3.V8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 0;
            Class1 ds = new Class1();
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine(res);
        }
    }
}