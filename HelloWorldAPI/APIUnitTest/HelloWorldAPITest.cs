using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Controllers;
namespace APIUnitTest
{
    [TestClass]
    public class HelloWorldAPITest
    {
        [TestMethod]
        public void StringValidation()
        {
            var HelloCo = new HelloController();
            var Output = HelloCo.Get();
            Assert.AreEqual("Hello World", Output);
        }
    }
}
