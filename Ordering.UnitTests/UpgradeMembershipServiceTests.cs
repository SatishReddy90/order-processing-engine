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
    public class UpgradeMembershipServiceTests
    {
        private readonly OrderFake orderFake;
        public UpgradeMembershipServiceTests()
        {
            this.orderFake = new OrderFake();
        }

        [Fact]
        public void ProcessOrder_WhenInvalidMembershipIdPassed_ThrowsException()
        {
            // Arragne
            OrderDomain orderDomain = this.orderFake.GetUpgradeMembershipOrder();
            orderDomain.Membership.MembershipId = 0;
            var membershipService = new UpgradeMembershipService();

            // Assert
            Assert.ThrowsAsync<MembeshipNotFoundException>(async() => await membershipService.ProcessOrder(orderDomain));
        }

        [Fact]
        public void ProcessOrder_return_true()
        {
            // Arragne
            OrderDomain orderDomain = this.orderFake.GetUpgradeMembershipOrder();
            var membershipService = new UpgradeMembershipService();

            // Act
            var result = membershipService.ProcessOrder(orderDomain);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Result);
        }
    }
}
