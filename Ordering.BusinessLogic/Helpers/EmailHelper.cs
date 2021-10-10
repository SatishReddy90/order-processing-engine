using Ordering.BusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.BusinessLogic.Helpers
{
    public class EmailHelper
    {
        public static bool SendEmail(string subject, string body, string toEmailId)
        {
            if (string.IsNullOrEmpty(toEmailId))
            {
                throw new EmailException("To email id can't be empty.");
            }

            //TBD - Send email logic

            return true;
        }
    }
}
