namespace Tyuiu.GoryaevTT.Sprint5.Task3.V8.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            FileInfo fl = new FileInfo(path);
            bool flExists = fl.Exists;
            Assert.IsTrue(flExists);
        }
    }
}
