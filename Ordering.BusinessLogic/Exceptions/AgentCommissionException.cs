using System;
using System.Runtime.Serialization;

namespace Ordering.BusinessLogic.Exceptions
{
    [Serializable]
    public class AgentCommissionException : Exception
    {
        public AgentCommissionException()
        {
        }

        public AgentCommissionException(string message) : base(message)
        {
        }

        public AgentCommissionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AgentCommissionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
