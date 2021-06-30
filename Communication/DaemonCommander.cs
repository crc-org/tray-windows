using System;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using HttpOverStream.NamedPipe;

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
			return getResultsForBasicCommand<ConfigResult>(BasicCommands.ConfigGet);
		}

		public static SetUnsetConfig SetConfig(ConfigSetCommand cmd)
		{
            var result = postResponse(BasicCommands.ConfigSet, JsonSerializer.Serialize(cmd.args), 30);
            return JsonSerializer.Deserialize<SetUnsetConfig>(result.Result);
        }

		public static SetUnsetConfig UnsetConfig(ConfigUnsetCommand cmd)
		{
            var result = postResponse(BasicCommands.ConfigUnset, JsonSerializer.Serialize(cmd.args), 30);
            return JsonSerializer.Deserialize<SetUnsetConfig>(result.Result);
		}

		public static LogsResult GetLogs()
        {
			return getResultsForBasicCommand<LogsResult>(BasicCommands.Logs);
        }

        private static string SendBasicCommand(string command, int timeout)
        {
            return getResponse(command, timeout).Result;
        }

        private static async Task<string> postResponse(string cmd, string content, int timeout)
        {

            var httpClient = new NamedPipeHttpClientBuilder(_daemonHTTPNamedPipe)
                .WithPerRequestTimeout(TimeSpan.FromSeconds(timeout))
                .Build();

            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            string command = String.Format("{0}/{1}", _apiPath, cmd);
            string body = String.Empty;

            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(command, httpContent);

                body = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    throw new APIException(body);
                }
            }
            catch (TimeoutException e)
            {
                throw new CommunicationException(e.Message);
            }
            catch (Exception e)
            {
                throw e;
            }

            return body;
        }

        private static async Task<string> getResponse(string cmd, int timeout)
        {
            var httpClient = new NamedPipeHttpClientBuilder(_daemonHTTPNamedPipe)
                .WithPerRequestTimeout(TimeSpan.FromSeconds(timeout))
                .Build();

            string command = String.Format("{0}/{1}", _apiPath, cmd);
            string body = String.Empty;

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(command);
                body = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    throw new APIException(body);
                }
            }
            catch (TimeoutException e)
            {
                throw new CommunicationException(e.Message);
            }
            catch (Exception e)
            {
                throw e;
            }

            return body;
        }
	}
}
