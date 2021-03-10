using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.Collections.Generic;

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
		private String socketPath = string.Format("{0}\\.crc\\crc.sock", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
		private Socket daemonSocket;
		private UnixEndPoint daemonSocketEp;
		public DaemonCommander()
		{
			daemonSocket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.Unspecified);
			daemonSocketEp = new UnixEndPoint(socketPath);
		}

		public string GetStatus()
		{
			return TryAndSendCommand("status");
		}
		
		public string GetVersion()
		{
			return TryAndSendCommand("version");
		}

		public string Start()
		{
			return TryAndSendCommand("start");
		}

		public string Stop()
		{
			return TryAndSendCommand("stop");
		}

		public string Delete()
		{
			return TryAndSendCommand("delete");
		}

		public string GetWebconsoleURL()
		{
			return TryAndSendCommand("webconsoleurl");
		}

		public string GetAllConfig()
		{
			return TryAndSendCommand("getconfig");
		}

		public string SetConfig(ConfigSetCommand cmd)
		{
			return TryAndSendCommand(cmd);
		}

		public string UnsetConfig(ConfigUnsetCommand cmd)
		{
			return TryAndSendCommand(cmd);
		}

		private string TryAndSendCommand(string command)
		{
			try
			{
				var resp = this.SendCommand(command);
				return resp;
			}
			catch (SocketException e)
			{
				throw e;
			}
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
				return Encoding.ASCII.GetString(resp);
			}
			catch (SocketException e)
			{
				throw e;
			}
		}

		private string TryAndSendCommand(ConfigSetCommand command)
		{
			try
			{
				var resp = this.SendCommand(command);
				return resp;
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
				var cmd = JsonConvert.SerializeObject(command, new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore
				});
				byte[] msg = Encoding.ASCII.GetBytes(cmd);
				daemonSocket.Send(msg);
				daemonSocket.Receive(resp);
				daemonSocket.Close();
				return Encoding.ASCII.GetString(resp);
			}
			catch (SocketException e)
			{
				throw e;
			}
		}
		private string TryAndSendCommand(ConfigUnsetCommand cmd)
		{
			try
			{
				var resp = this.SendCommand(cmd);
				return resp;
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
				var cmd = JsonConvert.SerializeObject(command, new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore
				});
				byte[] msg = Encoding.ASCII.GetBytes(cmd);
				daemonSocket.Send(msg);
				daemonSocket.Receive(resp);
				daemonSocket.Close();
				return Encoding.ASCII.GetString(resp);
			}
			catch (SocketException e)
			{
				throw e;
			}
		}
	}
}
