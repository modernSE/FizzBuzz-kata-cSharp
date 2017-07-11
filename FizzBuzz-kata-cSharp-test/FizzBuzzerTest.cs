using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzerTest
    {
        private FizzBuzzer fb = new FizzBuzzer();

        [TestMethod]
        public void RandomNumber()
        {
            Assert.AreEqual("4", fb.Translate(4));
        }

        [TestMethod]
        public void Fizz()
        {
            Assert.AreEqual("Fizz", fb.Translate(15));
        }

        [TestMethod]
        public void Buzz()
        {
            Assert.AreEqual("Buzz", fb.Translate(14));
        }

        [TestMethod]
        public void FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", fb.Translate(35));
        }
    }
}
