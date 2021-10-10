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
    public class PackingSlipHelperTests
    {
        private readonly OrderFake orderFake;
        public PackingSlipHelperTests()
        {
            this.orderFake = new OrderFake();
        }

        [Fact]
        public void GeneratePackingSlipForShipping_WhenInvalidOrderPassed_ThrowsException()
        {
            // Arragne
            Order order = null;

            // Assert
            Assert.Throws<PackingSlipGenerationException>(() => PackingSlipHelper.GeneratePackingSlipForShipping(order));
        }

        [Fact]
        public void GeneratePackingSlipForShipping_WhenOrderPassed_ReturnPackingSlip()
        {
            // Arragne
            var orderDomain = this.orderFake.GetPhysicalProductOrder();

            // Act
            var result = PackingSlipHelper.GeneratePackingSlipForShipping(orderDomain.Order);

            // Assert
            Assert.IsType<PackingSlip>(result);
        }
        [Fact]
        public void GeneratePackingSlipForRoyaltyDepartment_WhenInvalidOrderPassed_ThrowsException()
        {
            // Arragne
            Order order = null;

            // Assert
            Assert.Throws<PackingSlipGenerationException>(() => PackingSlipHelper.GeneratePackingSlipForRoyaltyDepartment(order));
        }

        [Fact]
        public void GeneratePackingSlipForRoyaltyDepartment_WhenOrderPassed_ReturnPackingSlip()
        {
            // Arragne
            var orderDomain = this.orderFake.GetBookOrder();

            // Act
            var result = PackingSlipHelper.GeneratePackingSlipForRoyaltyDepartment(orderDomain.Order);

            // Assert
            Assert.IsType<PackingSlip>(result);
        }
    }
}
