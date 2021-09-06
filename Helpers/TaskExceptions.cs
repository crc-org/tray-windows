using System;

namespace CRCTray.Helpers
{
    internal class RetryableTaskFailedException : Exception
    {
        public RetryableTaskFailedException(string message) : base(message) { }
    }
}
