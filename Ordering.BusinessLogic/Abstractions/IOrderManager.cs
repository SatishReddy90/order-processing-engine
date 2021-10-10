using Ordering.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.BusinessLogic.Abstractions
{
    public interface IOrderManager
    {
        IOrderService GetOrderService(int orderType);
    }
}
