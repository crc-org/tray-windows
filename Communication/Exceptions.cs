using System;

namespace CRCTray.Communication
{
    internal class APIException : Exception
    {
        public APIException(string message) : base(message) { }

    }

    internal class APINotFoundException : Exception
    {
        public APINotFoundException(string message) : base(message) { }

    }

    internal class APICommunicationException : Exception
    {
        public APICommunicationException(string message) : base(message) { }

    }

}
