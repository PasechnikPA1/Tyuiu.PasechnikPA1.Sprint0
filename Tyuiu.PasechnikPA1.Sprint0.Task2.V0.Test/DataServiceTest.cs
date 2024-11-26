using Tyuiu.PasechnikPA1.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PasechnikPA1.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ChechGetMessageValid()
        {
            var name = "Павел";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Павел", res);
        }
    }
}
