using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CRCTray.Communication
{

	static class DaemonCommander
	{
		static private string socketPath = string.Format("{0}\\.crc\\crc.sock", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
		static private Socket daemonSocket;
		static private UnixEndPoint daemonSocketEp;
		
		public static void Initialize()
		{
			daemonSocket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified);
			daemonSocketEp = new UnixEndPoint(socketPath);
		}

		private static T getResultsForBasicCommand<T>(String command)
		{
			return JsonSerializer.Deserialize<T>(SendBasicCommand(command));
		}

		public static StatusResult GetStatus()
		{
			return getResultsForBasicCommand<StatusResult>("status");
		}

		public static VersionResult GetVersion()
		{
			return getResultsForBasicCommand<VersionResult>("version");
		}

		public static StartResult Start()
		{
			return getResultsForBasicCommand<StartResult>("start");
		}

		public static StopResult Stop()
		{
			return getResultsForBasicCommand<StopResult>("stop");
		}

		public static DeleteResult Delete()
		{
			return getResultsForBasicCommand<DeleteResult>("delete");
		}

		public static ConsoleResult GetWebconsoleURL()
		{
			return getResultsForBasicCommand<ConsoleResult>("webconsoleurl");
		}

		public static ConfigResult GetAllConfig()
		{
			return getResultsForBasicCommand<ConfigResult>("getconfig");
		}

		public static SetUnsetConfig SetConfig(ConfigSetCommand cmd)
		{
			return JsonSerializer.Deserialize<SetUnsetConfig>(SendCommand(cmd));
		}

		public static SetUnsetConfig UnsetConfig(ConfigUnsetCommand cmd)
		{
			return JsonSerializer.Deserialize<SetUnsetConfig>(SendCommand(cmd));
		}

		private static string SendBasicCommand(string command)
		{
            var cmd = JsonSerializer.Serialize<BasicCommand>(new BasicCommand(command));
            return getSocketResponse(cmd);
		}

        private static string SendCommand(ConfigSetCommand command)
		{
			JsonSerializerOptions options = new JsonSerializerOptions();
			options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
			var cmd = JsonSerializer.Serialize<ConfigSetCommand>(command, options);

			return getSocketResponse(cmd);
		}

		private static string SendCommand(ConfigUnsetCommand command)
		{
			JsonSerializerOptions options = new JsonSerializerOptions();
			options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
			var cmd = JsonSerializer.Serialize<ConfigUnsetCommand>(command, options);

			return getSocketResponse(cmd);
		}

		private static string getSocketResponse(string cmd)
		{
			try
			{
				Initialize();

				var resp = new byte[16 * 1024];
				daemonSocket.Connect(daemonSocketEp);
				byte[] msg = Encoding.ASCII.GetBytes(cmd);
				daemonSocket.Send(msg);
				daemonSocket.Receive(resp);
				daemonSocket.Close();

				var result = Encoding.ASCII.GetString(resp);
				return result.Replace("\0", string.Empty);
			}

			catch (SocketException e)
			{
				throw e;
			}
		}
	}
}
