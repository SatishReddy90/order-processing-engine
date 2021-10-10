using System;
using System.Runtime.Serialization;

namespace Ordering.BusinessLogic.Exceptions
{
    [Serializable]
    public class PackingSlipGenerationException : Exception
    {
        public PackingSlipGenerationException()
        {
        }

        public PackingSlipGenerationException(string message) : base(message)
        {
        }

        public PackingSlipGenerationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PackingSlipGenerationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
