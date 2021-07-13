using System;

namespace CRCTray.Communication
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }

    }

    internal class APIException : Exception
    {
        public APIException(string message) : base(message) { }

    }

    internal class CommunicationException : Exception
    {
        public CommunicationException(string message) : base(message) { }

    }

}
