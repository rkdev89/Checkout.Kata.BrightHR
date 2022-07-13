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
            Till till = new();
            Assert.That(till.Scan("A"), Is.EqualTo(50m));
        }
    }
}