using Tyuiu.NoskovVI.Sprint7.Project.V8.Lib;
namespace Tyuiu.NoskovVI.Sprint7.Project.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void FileLoadedTest()
        {
            var ds = new DataService();
            string path = @"C:\DataSprint7\AutoTest.csv";
            List<string[]> wait = new List<string[]>();
            wait.Add(new string[] { "98", "А344КО", "Porshe", "Отличное", "В гараже", "70", "40", "60" });
            wait.Add(new string[] { "54", "45ЕНГ8", "КАМАЗ", "Требуется ТО", "Краснодар", "40", "200", "300" });
            CollectionAssert.AreEqual(wait, ds.LoadDataFromFile(path)); 
        }
    }
}
