using Ordering.BusinessLogic.Abstractions;
using Ordering.BusinessLogic.Exceptions;
using Ordering.BusinessLogic.Helpers;
using Ordering.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.BusinessLogic
{
    public class NewMembershipService : IOrderService
    {
        public async Task<bool> ProcessOrder(OrderDomain orderDomain)
        {
            if (orderDomain.Membership == null)
            {
                throw new OrderProcessingException("Invalid membership details");
            }

            await Task.Run(() =>
            {
                this.ActivateMembership(orderDomain.Membership);
                this.SendMembershipActivtionNotification(orderDomain.Membership);
            });

            return true;
        }

        private void SendMembershipActivtionNotification(Membership membership)
        {
            string subject = "Membership activation status";
            string body = $"Hi {membership.Name}, \nYour membership has been activated successfully.";
            EmailHelper.SendEmail(subject, body, membership.EmailId);
        }

        private void ActivateMembership(Membership membership)
        {
            // TBD: membership activation logic
        }
    }
}
