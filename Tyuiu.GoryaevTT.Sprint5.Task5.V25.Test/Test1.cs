using Tyuiu.GoryaevTT.Sprint5.Task5.V25.Lib;
namespace Tyuiu.GoryaevTT.Sprint5.Task5.V25.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5.V25.txt";
            FileInfo fl = new FileInfo(path);
            bool flEx = fl.Exists;
            Assert.IsTrue(flEx);
        }
    }
}
