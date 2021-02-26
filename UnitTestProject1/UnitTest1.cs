using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testcustomer = new Customer("Jakob", "Ottosen", "Lysbrovænget 2", 8600, "Silkeborg", new DateTime(1997, 7, 16));
        }
    }
}
