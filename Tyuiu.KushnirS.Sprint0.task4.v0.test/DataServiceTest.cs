using Tyuiu.KushnirS.Sprint0.task4.v0.lib;
namespace Tyuiu.KushnirS.Sprint0.task4.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedMinusValid()
        {
            Assert.AreEqual(5, DataService.Minus(10, 5));
        
        }
        public void CheckedDelValid()
        {
            Assert.AreEqual(2, DataService.Del(10, 5));

        }
        public void CheckedMultValid()
        {
            Assert.AreEqual(50, DataService.Mult(10, 5));

        }
    }
}