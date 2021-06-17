using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace CRCTray.Communication
{

	static class DaemonCommander
	{
		static private string socketPath = string.Format("{0}\\.crc\\crc.sock", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));

		public class DaemonException : Exception
		{
			public DaemonException(string message) : base(message)
			{
			}
		}
		
		private static T getResultsForBasicCommand<T>(string command)
		{
			var output = SendBasicCommand(command);
			var options = new JsonSerializerOptions
			{
				IgnoreNullValues = true
			};
			var status = JsonSerializer.Deserialize<Result>(output, options);
			if (status.Success)
			{
				return JsonSerializer.Deserialize<T>(output, options);
			}
			throw new DaemonException(status.Error);
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
			return getResultsForBasicCommand<StartResult>(BasicCommands.Start);
		}

		public static StopResult Stop()
		{
			return getResultsForBasicCommand<StopResult>(BasicCommands.Stop);
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
			return JsonSerializer.Deserialize<SetUnsetConfig>(SendCommand(cmd));
		}

		public static SetUnsetConfig UnsetConfig(ConfigUnsetCommand cmd)
		{
			return JsonSerializer.Deserialize<SetUnsetConfig>(SendCommand(cmd));
		}

		public static Logs GetLogs()
        {
			return getResultsForBasicCommand<Logs>(BasicCommands.Logs);
        }

		private static string SendBasicCommand(string command)
		{
            var cmd = JsonSerializer.Serialize(new BasicCommand(command));
            return getSocketResponse(cmd);
		}

        private static string SendCommand(ConfigSetCommand command)
		{
			JsonSerializerOptions options = new JsonSerializerOptions();
			options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
			var cmd = JsonSerializer.Serialize(command, options);

			return getSocketResponse(cmd);
		}

		private static string SendCommand(ConfigUnsetCommand command)
		{
			JsonSerializerOptions options = new JsonSerializerOptions();
			options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
			var cmd = JsonSerializer.Serialize(command, options);

			return getSocketResponse(cmd);
		}

		private static string getSocketResponse(string cmd)
		{
			try
			{
				Socket daemonSocket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified);
				UnixEndPoint daemonSocketEp = new UnixEndPoint(socketPath);

				var resp = new byte[16 * 1024];
				daemonSocket.Connect(daemonSocketEp);
				byte[] msg = Encoding.ASCII.GetBytes(cmd);
				daemonSocket.Send(msg);
				daemonSocket.Receive(resp);

				var result = Encoding.ASCII.GetString(resp);
				return result.Replace("\0", string.Empty);
			}

			catch (SocketException e)
			{
				Console.WriteLine("Exception occured");
				throw e;
			}
		}
	}
}
