using Tyuiu.KushnirS.Sprint0.task2.v0.lib;
namespace Tyuiu.KushnirS.Sprint0.task2.v0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "�����";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("������, �����", res);
        }
    }
}