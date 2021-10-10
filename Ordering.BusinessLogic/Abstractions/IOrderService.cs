using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.BusinessLogic.Abstractions
{
    public interface IOrderService
    {
        Task<bool> ProcessOrder(Order order);
    }
}
