using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.GoryaevTT.Sprint5.Task2.V30.Lib
{
    public class Class1 : ISprint5Task2V30
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fl = new FileInfo(path);
            bool flEx = fl.Exists;
            if (flEx)
            {
                File.Delete(path);
            }
            for (int i = 0; i <= matrix.GetLength(0); i++)
            {
                for (int j = 0; j <= matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string xxx = "";
            for (int i = 0; i <= matrix.GetLength(0); i++)
            {
                for (int j = 0;j <= matrix.GetLength(1); j++)
                {
                    if (j != matrix.GetLength(0))
                    {
                        xxx += matrix[i, j] + ";";
                    }
                    else
                    {
                        xxx += matrix[i, j];
                    }
                }
                if (i != matrix.GetLength(0))
                {
                    File.AppendAllText(path, xxx + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, xxx);
                }
                xxx = "";
            }
            return path;
        }
    }
}
