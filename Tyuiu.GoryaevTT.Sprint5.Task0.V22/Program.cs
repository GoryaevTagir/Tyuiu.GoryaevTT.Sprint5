using System.IO;
using Tyuiu.GoryaevTT.Sprint5.Task0.V22.Lib;
namespace Tyuiu.GoryaevTT.Sprint5.Task0.V22
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 3;
            Class1 ds = new Class1();
            string res = ds.SaveToFileTextData(x);
        }
    }
}