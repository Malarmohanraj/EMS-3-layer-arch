using System;
using System.Runtime.Serialization;

namespace Capgemini.EMS.Exceptions
{
    public class EMSExeptions : ApplicationException
    {
        public EMSExeptions()
        {
        }

        public EMSExeptions(string message) : base(message)
        {
        }

        public EMSExeptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EMSExeptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
