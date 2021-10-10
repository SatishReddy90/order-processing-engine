using Ordering.BusinessLogic;
using Ordering.BusinessLogic.Exceptions;
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
    public class NewMembershipServiceTests
    {
        private readonly OrderFake orderFake;
        public NewMembershipServiceTests()
        {
            this.orderFake = new OrderFake();
        }

        [Fact]
        public void ProcessOrder_WhenInvalidMembershipDetailPassed_ThrowsException()
        {
            // Arragne
            OrderDomain orderDomain = new OrderDomain();
            var membershipService = new NewMembershipService();

            // Assert
            Assert.ThrowsAsync<OrderProcessingException>(async() => await membershipService.ProcessOrder(orderDomain));
        }

        [Fact]
        public void ProcessOrder_return_true()
        {
            // Arragne
            var order = this.orderFake.GetNewMembershipOrder();
            var membershipService = new NewMembershipService();

            // Act
            var result = membershipService.ProcessOrder(order);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Result);
        }
    }
}
