using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRCTray.Communication;

namespace CRCTray.Helpers
{
   internal class TaskHelpers
   {
       public static async Task<T> TryTask<T>(Func<T> function)
       {
            try
            {
                return await Task.Run(function);
            }
            catch (AggregateException ae)
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
                        return true;
                    }

                    if (x is TaskCanceledException)
                    {
                        return true;
                    }

                    return false;

                });
            }

            return default;
       }

       public static async Task<T> TryTask<T, TArgs>(Func<TArgs, T> function, TArgs args)
       {
            try
            {
                return await Task.Run(() => function(args));
            }
            catch (AggregateException ae)
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
                        return true;
                    }

                    if (x is TimeoutException || x is TaskCanceledException)
                    {
                        return true;
                    }

                    return false;

                });
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
                           TrayIcon.NotifyError(
$@"{failureMessage}
{x.Message}");

                       return true;
                   }

                   if (x is TaskCanceledException)
                   {
                       if (!String.IsNullOrEmpty(canceledMessage))
                           TrayIcon.NotifyInfo(canceledMessage);

                       return true;
                   }

                   return false;

               });
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
                           TrayIcon.NotifyError(
 $@"{failureMessage}
{x.Message}");

                       return true;
                   }

                   if (x is TimeoutException || x is TaskCanceledException )
                   {
                       if(!String.IsNullOrEmpty(canceledMessage))
                           TrayIcon.NotifyInfo(canceledMessage);

                       return true;
                   }

                   return false;

               });
           }

           return default;
       }
   }
}
