using Tyuiu.GoryaevTT.Sprint5.Task0.V22.Lib;
using System.IO;
namespace Tyuiu.GoryaevTT.Sprint5.Task0.V22.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fl = new FileInfo(path);
            bool fileExists = fl.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
