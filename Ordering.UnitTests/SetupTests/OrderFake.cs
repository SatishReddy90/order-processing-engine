using Ordering.Domain.Enums;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.UnitTests.SetupTests
{
    public class OrderFake
    {
        public Order GetOrder()
        {
            return new Order()
            {
                OrderId = 1,
                Quantity = 5,
                OrderType = OrderType.PhysicalProduct,
            };
        }
    }
}
