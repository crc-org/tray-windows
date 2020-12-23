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
			try
			{
				var resp = this.SendCommand("status");
				return resp;
			}
			catch (SocketException e)
			{
				throw e;
			}
		}
		
		public string GetVersion()
		{
			try
			{
				var resp = this.SendCommand("version");
				return resp;
			}
			catch (SocketException e)
			{
				throw e;
			}
		}

		public string Start()
		{
			try
			{
				var resp = this.SendCommand("start");
				return resp;
			}
			catch (SocketException e)
			{
				throw e;
			}
		}

		public string Stop()
		{
			try
			{
				var resp = this.SendCommand("stop");
				return resp;
			}
			catch (SocketException e)
			{
				throw e;
			}
		}

		public string Delete()
		{
			try
			{
				var resp = this.SendCommand("delete");
				return resp;
			}
			catch (SocketException e)
			{
				throw e;
			}
		}

		public string GetWebconsoleURL()
		{
			try
			{
				var resp = this.SendCommand("webconsoleurl");
				return resp;
			}
			catch (SocketException e)
			{
				throw e;
			}
		}

		public string GetAllConfig()
		{
			try
			{
				var resp = this.SendCommand("getconfig");
				return resp;
			}
			catch (SocketException e)
			{
				throw e;
			}
		}

		public string SetConfig(ConfigSetCommand cmd)
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

		public string UnsetConfig(ConfigUnsetCommand cmd)
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

		private string SendCommand(string command)
		{
			try
			{
				var resp = new byte[2048];
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
