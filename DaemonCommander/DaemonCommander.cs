using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace tray_windows.Daemon
{
    class DaemonCommander
    {
		private String socketPath = "C:\\Users\\Anjan\\.crc\\crc.sock"; // make this path by getting users home dir
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
		private string SendCommand(string command)
		{
			try
			{
				var resp = new byte[1024];
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
	}
}
