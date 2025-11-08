using Tyuiu.GoryaevTT.Sprint5.Task4.V14.Lib;
namespace Tyuiu.GoryaevTT.Sprint5.Task4.V14.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            string path = @"C:\DataSprint5\InPutDataFileTask4V14.txt";
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(res, res);
        }
    }
}
