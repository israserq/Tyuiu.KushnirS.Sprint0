using Tyuiu.KushnirS.Sprint0.task3.v0.lib;
namespace Tyuiu.KushnirS.Sprint0.task3.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}