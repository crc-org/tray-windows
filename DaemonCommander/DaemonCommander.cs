using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tray_windows.Daemon
{
	struct ConfigSetCommand
	{
		public string command;
		public ConfigSetCommandArg args;
	}

	struct ConfigSetCommandArg
	{
		public Dictionary<string, dynamic> properties;
	}

	struct ConfigUnsetCommand
	{
		public string command;
		public ConfigUnsetCommandArg args;
	}

	struct ConfigUnsetCommandArg
	{
		public List<string> properties;
	}

	class DaemonCommander
	{
		private string socketPath = string.Format("{0}\\.crc\\crc.sock", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
		private Socket daemonSocket;
		private UnixEndPoint daemonSocketEp;
		public DaemonCommander()
		{
			daemonSocket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified);
			daemonSocketEp = new UnixEndPoint(socketPath);
		}

		public string GetStatus()
		{
			return SendCommand("status");
		}
		
		public string GetVersion()
		{
			return SendCommand("version");
		}

		public string Start()
		{
			return SendCommand("start");
		}

		public string Stop()
		{
			return SendCommand("stop");
		}

		public string Delete()
		{
			return SendCommand("delete");
		}

		public string GetWebconsoleURL()
		{
			return SendCommand("webconsoleurl");
		}

		public string GetAllConfig()
		{
			return SendCommand("getconfig");
		}

		public string SetConfig(ConfigSetCommand cmd)
		{
			return SendCommand(cmd);
		}

		public string UnsetConfig(ConfigUnsetCommand cmd)
		{
			return SendCommand(cmd);
		}

		private string SendCommand(string command)
		{
			try
			{
				var resp = new byte[16 * 1024];
				daemonSocket.Connect(daemonSocketEp);
				var cmd = $"{{\"command\":\"{command}\"}}";
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

		private string SendCommand(ConfigSetCommand command)
		{
			try
			{
				var resp = new byte[2048];
				daemonSocket.Connect(daemonSocketEp);

				JsonSerializerOptions options = new JsonSerializerOptions();
				options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
				var cmd = JsonSerializer.Serialize<ConfigSetCommand>(command, options);

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

		private string SendCommand(ConfigUnsetCommand command)
		{
			try
			{
				var resp = new byte[2048];
				daemonSocket.Connect(daemonSocketEp);

				JsonSerializerOptions options = new JsonSerializerOptions();
				options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
				var cmd = JsonSerializer.Serialize<ConfigUnsetCommand>(command, options);

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
