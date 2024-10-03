using Tyuiu.KushnirS.Sprint0.task6.v0.lib;
namespace Tyuiu.KushnirS.Sprint0.task6.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void checkAdditionArrayValid()
        {
            var numbers = new int[]{1, 2, 3, 4, 5};
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        public void checkMinusArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MinusArray(numbers);
            Assert.AreEqual(-15, res);
        }
        public void checkMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}