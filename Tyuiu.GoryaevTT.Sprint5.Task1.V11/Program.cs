using Tyuiu.GoryaevTT.Sprint5.Task1.V11.Lib;
using System.IO;
namespace Tyuiu.GoryaevTT.Sprint5.Task1.V11
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            int startv = -5;
            int endv = 5;
            string res = ds.SaveToFileTextData(startv, endv);
            string path = Path.GetDirectoryName(res);
            string[] ff = File.ReadAllLines(path);
            for (int i = startv; i <= endv; i++)
            {
                foreach (string el in ff)
                {
                    Console.WriteLine($"{i} | {el}");
                } 
            }
        }
    }
}