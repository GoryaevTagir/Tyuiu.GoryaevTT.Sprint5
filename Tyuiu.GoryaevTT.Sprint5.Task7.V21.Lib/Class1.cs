using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GoryaevTT.Sprint5.Task7.V21.Lib
{
    public class Class1 : ISprint5Task7V21
    {
        public string LoadDataAndSave(string path)
        {
            string ans = File.ReadAllText(path);
            string res = "";
            foreach (char c in ans)
            {
                string z = c.ToString();
                if (z != "!"&& z != "?" && z != "-" && z != "," && z != ".")
                {
                    res += z;
                }
            }
            return res;
        }
    }
}
