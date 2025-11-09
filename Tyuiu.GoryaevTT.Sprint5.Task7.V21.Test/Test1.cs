using Tyuiu.GoryaevTT.Sprint5.Task7.V21;
namespace Tyuiu.GoryaevTT.Sprint5.Task7.V21.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V21.txt";
            FileInfo fl = new FileInfo(path);
            bool flEx = fl.Exists;
            Assert.IsTrue(flEx);
        }
    }
}
