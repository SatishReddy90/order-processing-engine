using System;
using System.Runtime.Serialization;

namespace Ordering.BusinessLogic
{
    [Serializable]
    public class MembeshipNotFoundException : Exception
    {
        public MembeshipNotFoundException()
        {
        }

        public MembeshipNotFoundException(string message) : base(message)
        {
        }

        public MembeshipNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MembeshipNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}