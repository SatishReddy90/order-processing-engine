using Ordering.BusinessLogic.Abstractions;
using Ordering.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.BusinessLogic
{
    public class OrderManager : IOrderManager
    {
        public IOrderService GetOrderService(int orderType)
        {
            IOrderService orderService = null;
            switch (orderType)
            {
                case (int)OrderType.PhysicalProduct:
                    orderService = new PhysicalProductOrderService();
                    break;
                case (int)OrderType.Book:
                    orderService = new BookOrderService();
                    break;
            }

            return orderService;
        }
    }
}
