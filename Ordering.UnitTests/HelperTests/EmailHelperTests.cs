using Ordering.BusinessLogic.Exceptions;
using Ordering.BusinessLogic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ordering.UnitTests.HelperTests
{
    public class EmailHelperTests
    {
        [Fact]
        public void SendEmail_WhenEmptyEmailIdPassed_ThrowsException()
        {
            // Arragne
            string subject = "Membership activation status";
            string body = "The membership has been activated successfully.";
            string toEmailId = string.Empty;

            // Assert
            Assert.Throws<EmailException>(() => EmailHelper.SendEmail(subject, body, toEmailId));
        }

        [Fact]
        public void SendEmail_returns_true()
        {
            // Arragne
            string subject = "Membership activation status";
            string body = "The membership has been activated successfully.";
            string toEmailId = "test@abc.com";

            // Act
            var result = EmailHelper.SendEmail(subject, body, toEmailId);

            // Assert
            Assert.True(result);
        }
    }
}
