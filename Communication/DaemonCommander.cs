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

		public static StatusResult GetStatus()
		{
			return JsonSerializer.Deserialize<StatusResult>(SendCommand("status"));
		}

		public static VersionResult GetVersion()
		{
			return JsonSerializer.Deserialize<VersionResult>(SendCommand("version"));
		}

		public static StartResult Start()
		{
			return JsonSerializer.Deserialize<StartResult>(SendCommand("start"));
		}

		public static StopResult Stop()
		{
			return JsonSerializer.Deserialize<StopResult>(SendCommand("stop"));
		}

		public static DeleteResult Delete()
		{
			return JsonSerializer.Deserialize<DeleteResult>(SendCommand("delete"));
		}

		public static ConsoleResult GetWebconsoleURL()
		{
			return JsonSerializer.Deserialize<ConsoleResult>(SendCommand("webconsoleurl"));
		}

		public static ConfigResult GetAllConfig()
		{
			return JsonSerializer.Deserialize<ConfigResult>(SendCommand("getconfig"));
		}

		public static SetUnsetConfig SetConfig(ConfigSetCommand cmd)
		{
			return JsonSerializer.Deserialize<SetUnsetConfig>(SendCommand(cmd));
		}

		public static SetUnsetConfig UnsetConfig(ConfigUnsetCommand cmd)
		{
			return JsonSerializer.Deserialize<SetUnsetConfig>(SendCommand(cmd));
		}

		private static string SendCommand(string command)
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
