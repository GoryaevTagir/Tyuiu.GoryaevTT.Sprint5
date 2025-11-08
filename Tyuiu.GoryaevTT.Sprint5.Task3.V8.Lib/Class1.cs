using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.Unicode;
using System.Text;
namespace Tyuiu.GoryaevTT.Sprint5.Task3.V8.Lib
{
    public class Class1 : ISprint5Task3V8
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            double z = Math.Round((Math.Pow(x, 2) + 1)/(3*x + 4), 3);
            using (BinaryWriter wr = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), encoding:Encoding.UTF8))
            {
                wr.Write(BitConverter.GetBytes(z));
            }
            return path;
        }
    }
}
