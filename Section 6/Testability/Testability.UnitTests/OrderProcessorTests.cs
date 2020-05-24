using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testability;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        //methordname_condition_expectation
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnExpection()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}