using System;
using System.Runtime.Serialization;

namespace Ordering.BusinessLogic.Exceptions
{
    [Serializable]
    public class OrderProcessingException : Exception
    {
        public OrderProcessingException()
        {
        }

        public OrderProcessingException(string message) : base(message)
        {
        }

        public OrderProcessingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OrderProcessingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
