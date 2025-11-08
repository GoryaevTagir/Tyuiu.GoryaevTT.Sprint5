using Tyuiu.GoryaevTT.Sprint5.Task2.V30.Lib;
using System.IO;
namespace Tyuiu.GoryaevTT.Sprint5.Task2.V30.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fl = new FileInfo(path);
            bool flExists = fl.Exists;
            Assert.IsTrue(flExists);
        }
    }
}
