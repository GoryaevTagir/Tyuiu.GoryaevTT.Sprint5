using Tyuiu.GoryaevTT.Sprint5.Task6.V8.Lib;
namespace Tyuiu.GoryaevTT.Sprint5.Task6.V8.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6.V8.txt";
            FileInfo fl = new FileInfo(path);
            bool flEx = fl.Exists;
            Assert.IsTrue(flEx);
        }
    }
}
