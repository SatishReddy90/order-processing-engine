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
        public OrderDomain GetPhysicalProductOrder()
        {
            return new OrderDomain()
            {
                Order = new Order()
                {
                    OrderId = 1,
                    Quantity = 5,
                    OrderType = OrderType.PhysicalProduct,
                }
            };
        }

        public OrderDomain GetBookOrder()
        {
            return new OrderDomain()
            {
                Order = new Order()
                {
                    OrderId = 1,
                    Quantity = 1,
                    OrderType = OrderType.Book,
                }
            };
        }

        public OrderDomain GetNewMembershipOrder()
        {
            return new OrderDomain()
            {
                Order = new Order()
                {
                    OrderId = 1,
                    Quantity = 1,
                    OrderType = OrderType.NewMembership,
                },
                Membership = new Membership()
                {
                    Name = "John Doe",
                    EmailId = "john.doe@testmail.com",
                    ValidFrom = DateTime.Now,
                    ValidThrough = DateTime.Now.AddYears(1),
                },
            };
        }

        public OrderDomain GetUpgradeMembershipOrder()
        {
            return new OrderDomain()
            {
                Order = new Order()
                {
                    OrderId = 1,
                    Quantity = 1,
                    OrderType = OrderType.UpgradeMembership,
                },
                Membership = new Membership()
                {
                    MembershipId = 1,
                    Name = "John Doe",
                    EmailId = "john.doe@testmail.com",
                    ValidFrom = DateTime.Now,
                    ValidThrough = DateTime.Now.AddYears(1),
                },
            };
        }
    }
}
