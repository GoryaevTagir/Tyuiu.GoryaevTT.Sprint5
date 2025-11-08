using Tyuiu.GoryaevTT.Sprint5.Task2.V30.Lib;
namespace Tyuiu.GoryaevTT.Sprint5.Task2.V30
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] mtx = new int[3, 3] { {3, -1, -3}, {-2, -5, 0 }, {-8, -7, 2 } };
            Class1 ds = new Class1();
            string res = ds.SaveToFileTextData(mtx);
            Console.WriteLine(res);
        }
    }
}