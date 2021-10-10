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
    public class UpgradeMembershipService : IOrderService
    {
        public async Task<bool> ProcessOrder(OrderDomain orderDomain)
        {
            if (!this.CheckMembershipExistence(orderDomain.Membership.MembershipId))
            {
                throw new MembeshipNotFoundException($"Membership doesnot exist with id {orderDomain.Membership.MembershipId}");
            }

            await Task.Run(() =>
            {
                this.UpgradeMembership(orderDomain.Membership);
                this.SendMembershipActivtionNotification(orderDomain.Membership);
            });

            return true;
        }

        private void SendMembershipActivtionNotification(Membership membership)
        {
            string subject = "Membership upgrade status";
            string body = $"Hi {membership.Name}, \nYour membership has been upgraded successfully.";
            EmailHelper.SendEmail(subject, body, membership.EmailId);
        }

        private bool CheckMembershipExistence(int membershipId)
        {
            // TBD: membership fetch logic

            if (membershipId <= 0)
            {
                return false;
            }

            return true;
        }

        private void UpgradeMembership(Membership membership)
        {
            // TBD: membership upgradation logic
        }

    }
}
