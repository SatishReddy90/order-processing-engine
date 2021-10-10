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
        public async Task<bool> ProcessOrder(Order order)
        {
            await Task.Run(() =>
            {
                var packingSlip = PackingSlipHelper.GeneratePackingSlipForShipping(order);
                var commission = AgentCommissionHelper.GeneratePaymentCommissionToAgent(order);
            });

            return true;
        }
    }
}
