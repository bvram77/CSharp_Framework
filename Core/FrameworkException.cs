using System;
using System.Runtime.Serialization;

namespace com.venkat.framework.core
{
    [Serializable]
    internal class FrameworkException : Exception
    {
        public String ErrorName = "Error";
        private String UsrErrMsg;

        public FrameworkException()
        {
        }

        public FrameworkException(String ErrDescription) : base(ErrDescription)
        {
            base.ToString();
        }

        public FrameworkException(String ErrDescription, String UsrErrMsg) : base(ErrDescription)
        {
            this.UsrErrMsg = UsrErrMsg;
        }

        public FrameworkException(String ErrDescription, Exception InnerException) : base(ErrDescription, InnerException)
        {
            base.ToString();
            this.ErrorName = ErrDescription;
        }

        protected FrameworkException(SerializationInfo Info, StreamingContext Context) : base(Info, Context)
        {
        }
    }
}