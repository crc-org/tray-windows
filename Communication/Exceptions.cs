using System;

namespace CRCTray.Communication
{
    internal class APIException : Exception
    {
        public APIException(string message) : base(message) { }

    }

    internal class CommunicationException : Exception
    {
        public CommunicationException(string message) : base(message) { }

    }

}
