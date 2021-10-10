using Ordering.BusinessLogic;
using Ordering.BusinessLogic.Abstractions;
using System;
using Xunit;

namespace Ordering.UnitTests
{
    public class OrderManagerTests
    {
        [Fact]
        public void GetOrderService_UnknownOrderTypePassed_ReturnsNull()
        {
            // Arragne
            var orderType = 0;
            var orderManager = new OrderManager();

            // Act
            var result = orderManager.GetOrderService(orderType);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void GetOrderService_ValidOrderTypePassed_ReturnsRightOrderService()
        {
            // Arragne
            var orderType = 1;
            var orderManager = new OrderManager();

            // Act
            var result = orderManager.GetOrderService(orderType);

            // Assert
            Assert.IsType<PhysicalProductOrderService>(result);
        }
    }
}
