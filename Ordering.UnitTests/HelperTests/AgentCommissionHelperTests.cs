using Ordering.BusinessLogic.Exceptions;
using Ordering.BusinessLogic.Helpers;
using Ordering.Domain.Enums;
using Ordering.Domain.Models;
using Ordering.UnitTests.SetupTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ordering.UnitTests.HelperTests
{
    public class AgentCommissionHelperTests
    {
        private readonly OrderFake orderFake;
        public AgentCommissionHelperTests()
        {
            this.orderFake = new OrderFake();
        }

        [Fact]
        public void GeneratePaymentCommissionToAgent_WhenInvalidOrderPassed_ThrowsException()
        {
            // Arragne
            Order order = null;

            // Assert
            Assert.Throws<AgentCommissionException>(() => AgentCommissionHelper.GeneratePaymentCommissionToAgent(order));
        }

        [Fact]
        public void GeneratePaymentCommissionToAgent_WhenOrderPassed_ReturnCommissionAmount()
        {
            // Arragne
            Order order = this.orderFake.GetOrder();

            // Act
            var result = AgentCommissionHelper.GeneratePaymentCommissionToAgent(order);

            // Assert
            Assert.IsType<double>(result);
        }

        private Order GetOrderFake()
        {
            return new Order()
            {
                OrderId = 1,
                OrderType = OrderType.Book,
            };
        }
    }
}
