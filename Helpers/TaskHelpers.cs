using System;
using System.Threading;
using System.Threading.Tasks;
using CRCTray.Communication;

namespace CRCTray.Helpers
{
    internal class TaskHelpers
    {
        public static async Task<T> TryTask<T>(Func<T> function)
        {
            return await tryTask(function, false);
        }

        private static async Task<T> tryTask<T>(Func<T> function, bool OnlyHandleAPIExceptions)
        {
            try
            {
                return await Task.Run(function);
            }
            catch (AggregateException ae)
            {
                handleAggregate(ae, OnlyHandleAPIExceptions);
            }

            return default;
        }

        public static async Task<T> TryTaskWithRetry<T>(Func<T> function, int attempts = 3, int backOff = 2000)
        {
            var retryCount = 0;

            for(; ;)
            {
                if(retryCount > attempts)
                {
                    throw new RetryableTaskFailedException($"Re-tried task {retryCount} times");
                }

                try
                {
                    return await tryTask(function, true);
                }

                catch(AggregateException ae)
                {
                    ae.Handle((x) =>
                    {

                        if (x is TimeoutException || x is TaskCanceledException)
                        {
                            retryCount++;
                            // backoff for 2 seconds
                            Thread.Sleep(backOff);
                            
                            return true;
                        }

                        // should not reach here
                        return false;
                    });

                }

            }

        }

        public static async Task<T> TryTask<T, TArgs>(Func<TArgs, T> function, TArgs args)
        {
            try
            {
                return await Task.Run(() => function(args));
            }
            catch (AggregateException ae)
            {
                handleAggregate(ae);
            }

            return default;
        }

        public static async Task<T> TryTaskAndNotify<T>(Func<T> function, string successMessage, string failureMessage, string canceledMessage)
        {
            try
            {
               var result = await Task.Run(function);

               if (!String.IsNullOrEmpty(successMessage))
                   TrayIcon.NotifyInfo(successMessage);

               return result;
            }
            catch (AggregateException ae)
            {
                handleAggregateWithNotify(failureMessage, canceledMessage, ae);
            }

            return default;
       }

        public static async Task<T> TryTaskAndNotify<T, TArgs>(Func<TArgs, T> function, TArgs args, string successMessage, string failureMessage, string canceledMessage)
        {
            try
            {
               var result = await Task.Run(() => function(args));

               if (!String.IsNullOrEmpty(successMessage))
                   TrayIcon.NotifyInfo(successMessage);

               return result;
            }
            catch (AggregateException ae)
            {
                handleAggregateWithNotify(failureMessage, canceledMessage, ae);
            }

            return default;
        }

        private static void handleAggregate(AggregateException ae, bool OnlyHandleAPIExceptions = false)
        {
            handleAggregateWithNotify(String.Empty, String.Empty, ae, OnlyHandleAPIExceptions);
        }

        private static void handleAggregateWithNotify(string failureMessage, string canceledMessage, AggregateException ae, bool OnlyHandleAPIExceptions = false)
        {
            ae.Handle((x) =>
            {
                if (x is APICommunicationException) // This we know how to handle.
                {
                    // TODO: start counting and eventually notify

                    return true;
                }

                if (x is APIException) // This we know how to handle.
                {
                    if (!String.IsNullOrEmpty(failureMessage))
                        TrayIcon.NotifyError($@"{failureMessage} {x.Message}");

                    return true;
                }

                // The TimeoutException or TaskCacnceledExceptions are returned to be handled outside
                // this can be used to implement a retry in case of these exceptions
                if (OnlyHandleAPIExceptions)
                    return false;

                if (x is TimeoutException || x is TaskCanceledException)
                {
                    if (!String.IsNullOrEmpty(canceledMessage))
                        TrayIcon.NotifyInfo(canceledMessage);

                    return true;
                }

                return false;

            });
        }
    }

}
