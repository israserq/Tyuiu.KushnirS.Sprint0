using Tyuiu.KushnirS.Sprint0.task5.v0.lib;
namespace Tyuiu.KushnirS.Sprint0.task5.v0.test

{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void CheckedDelValid()
        {
                Assert.AreEqual(2, DataService.Del(10, 5));
        }
    }
}