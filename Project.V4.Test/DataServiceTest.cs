using Project.V4.Lib;

namespace Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckOpenFile()
        {
            string path = "D:\\mine datastore\\study\\учеба 2024\\программирование\\DataBooks.csv";
            DataService ds = new DataService();
            string[,] result = ds.LoadFromFileData(path);
            Assert.AreEqual("978-3-16-148410-0", result[0,0]);
        }
        [TestMethod]
        public void CheckDatabase()
        {
            string path = "D:\\mine datastore\\study\\учеба 2024\\программирование\\DataBooks.csv";
            DataService ds = new DataService();
            string result = ds.CheckDataBase(path);
            Assert.AreEqual("books", result);
        }
    }
}