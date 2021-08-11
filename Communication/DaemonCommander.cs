using System;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using HttpOverStream.NamedPipe;
using System.Net.Http.Json;

namespace CRCTray.Communication
{

	static class DaemonCommander
	{
		private static readonly string _daemonHTTPNamedPipe = "crc-http";
        private static readonly string _apiPath = "/api";

        private static T getResultsForBasicCommand<T>(string command, int timeout = 20)
        {
            var output = SendBasicCommand(command, timeout);

            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true
            };

            if (String.IsNullOrEmpty(output))
                return default;

            return JsonSerializer.Deserialize<T>(output, options);
        }

		public static StatusResult Status()
		{
			return getResultsForBasicCommand<StatusResult>(BasicCommands.Status);
        }

		public static VersionResult Version()
		{
			return getResultsForBasicCommand<VersionResult>(BasicCommands.Version);
        }

		public static StartResult Start()
		{
			return getResultsForBasicCommand<StartResult>(BasicCommands.Start, 600);
        }

		public static StopResult Stop()
		{
			return getResultsForBasicCommand<StopResult>(BasicCommands.Stop, 120);
        }

		public static DeleteResult Delete()
		{
			return getResultsForBasicCommand<DeleteResult>(BasicCommands.Delete);
		}

		public static ConsoleResult ConsoleUrl()
		{
			return getResultsForBasicCommand<ConsoleResult>(BasicCommands.ConsoleUrl);
		}

		public static ConfigResult ConfigView()
		{
			return getResultsForBasicCommand<ConfigResult>(BasicCommands.Config);
		}

		public static SetUnsetConfig SetConfig(ConfigSetCommand cmd)
		{
            var result = sendPostRequest(BasicCommands.Config, JsonSerializer.Serialize(cmd.args), 30);
            return JsonSerializer.Deserialize<SetUnsetConfig>(result.Result);
        }

		public static SetUnsetConfig UnsetConfig(ConfigUnsetCommand cmd)
		{
            var result = sendDeleteRequest(BasicCommands.Config, JsonSerializer.Serialize(cmd.args), 30);
            return JsonSerializer.Deserialize<SetUnsetConfig>(result.Result);
		}

		public static LogsResult GetLogs()
        {
			return getResultsForBasicCommand<LogsResult>(BasicCommands.Logs);
        }

        public static bool GetPullSecret()
        {
            try
            {
                // On success the API returns 200 but no value.
                getResultsForBasicCommand<bool>(BasicCommands.PullSecret);
                return true;
            }

            catch (AggregateException ae)
            {
                ae.Handle((x) =>
                {
                    if (x is APINotFoundException) // This we know how to handle.
                    {
                        // Marking as handled
                        return true;
                    }

                    return false;
                });

                return false;
            }
        }

        public static bool SetPullSecret(string data)
        {
            var result = sendPostRequest(BasicCommands.PullSecret, data, 30);
            return true;
        }

        public static void PostTelemetryRecord(string action)
        {
            var tr = new TelemetryRecord()
            {
                action = action,
                source = "tray"
            };
            _ = sendPostRequest(BasicCommands.Telemetry, JsonSerializer.Serialize(tr), 30);
        }

        private static string SendBasicCommand(string command, int timeout)
        {
            return sendGetRequest(command, timeout).Result;
        }

        private static async Task<string> sendGetRequest(string command, int timeout)
        {
            return await sendRequest(prepareRequest(HttpMethod.Get,
                                                    string.Format("{0}/{1}", _apiPath, command)),
                                                    timeout);
        }

        private static async Task<string> sendPostRequest(string command, string content, int timeout)
        {
            return await sendRequest(prepareRequest(HttpMethod.Post,
                                                    string.Format("{0}/{1}", _apiPath, command),
                                                    content), timeout);
        }

        
        private static async Task<string> sendDeleteRequest(string command, string content, int timeout)
        {    
            return await sendRequest(prepareRequest(HttpMethod.Delete,
                                                    String.Format("{0}/{1}", _apiPath, command),
                                                    content), timeout);
        }

        private static async Task<string> sendRequest(HttpRequestMessage request, int timeout)
        {
            var httpClient = new NamedPipeHttpClientBuilder(_daemonHTTPNamedPipe)
                .WithPerRequestTimeout(TimeSpan.FromSeconds(timeout))
                .Build();

            string body = string.Empty;

            try
            {
                HttpResponseMessage response = await httpClient.SendAsync(request);

                body = await response.Content.ReadAsStringAsync();

                switch (response.StatusCode)
                {
                    case HttpStatusCode.InternalServerError:
                        throw new APIException(body);
                    case HttpStatusCode.NotFound:
                        throw new APINotFoundException(body);
                }
            }
            catch (TimeoutException e)
            {
                throw new APICommunicationException(e.Message);
            }
            catch (Exception e)
            {
                throw e;
            }

            return body;
        }

        private static HttpRequestMessage prepareRequest(HttpMethod method, string uri, string content)
        {
            return new HttpRequestMessage
            {
                Content = new StringContent(content, Encoding.UTF8, "application/json"),
                Method = method,
                RequestUri = new Uri(uri, UriKind.RelativeOrAbsolute)
            };
        }

        private static HttpRequestMessage prepareRequest(HttpMethod method, string uri)
        {
            return  new HttpRequestMessage
            {
                Method = method,
                RequestUri = new Uri(uri, UriKind.RelativeOrAbsolute)
            };
        }
    }
}
