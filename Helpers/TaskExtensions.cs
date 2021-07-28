using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRCTray.Helpers
{
    public static class TaskExtensions
    {
        public static void NoAwait(this Task task)
        {
            // Do nothing to suppress not awaited warnings
        }
    }
}
