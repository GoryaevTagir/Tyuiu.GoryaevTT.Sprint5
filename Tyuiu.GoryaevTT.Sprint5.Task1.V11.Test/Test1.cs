using Tyuiu.GoryaevTT.Sprint5.Task1.V11.Lib;
using System.IO;
namespace Tyuiu.GoryaevTT.Sprint5.Task1.V11.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}
