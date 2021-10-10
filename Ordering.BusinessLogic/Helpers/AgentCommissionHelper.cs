using Ordering.BusinessLogic.Exceptions;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.BusinessLogic.Helpers
{
    public class AgentCommissionHelper
    {
        public static double GeneratePaymentCommissionToAgent(Order order)
        {
            if (order == null)
            {
                throw new AgentCommissionException("Payment commission amount can't be calculated for invalid order.");
            }

            double agentCommission = 0.0;

            // Perform commission genration logic based on the provided order details.

            return agentCommission;
        }
    }
}
