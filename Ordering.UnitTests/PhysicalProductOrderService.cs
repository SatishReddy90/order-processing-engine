using Ordering.BusinessLogic;
using Ordering.Domain.Enums;
using Ordering.Domain.Models;
using Ordering.UnitTests.SetupTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ordering.UnitTests
{
    public class PhysicalProductOrderServiceTests
    {
        private readonly OrderFake orderFake;
        public PhysicalProductOrderServiceTests()
        {
            this.orderFake = new OrderFake();
        }

        [Fact]
        public void ProcessOrder_return_true()
        {
            // Arragne
            var order = this.orderFake.GetPhysicalProductOrder();
            var orderService = new PhysicalProductOrderService();

            // Act
            var result = orderService.ProcessOrder(order);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Result);
        }
    }
}
