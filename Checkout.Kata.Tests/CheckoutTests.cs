namespace Checkout.Kata.Tests
{
    [TestFixture]
    public class CheckoutTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingleProductScannedAndReturnsPrice()
        {
            Assert.AreEqual(0, till.Scan("A"));
        }
    }
}