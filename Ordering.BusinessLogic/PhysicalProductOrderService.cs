using Ordering.BusinessLogic.Abstractions;
using Ordering.BusinessLogic.Helpers;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.BusinessLogic
{
    public class PhysicalProductOrderService : IOrderService
    {
        public async Task<bool> ProcessOrder(OrderDomain orderDomain)
        {
            await Task.Run(() =>
            {
                var packingSlip = PackingSlipHelper.GeneratePackingSlipForShipping(orderDomain.Order);
                var commission = AgentCommissionHelper.GeneratePaymentCommissionToAgent(orderDomain.Order);
            });

            return true;
        }
    }
}
