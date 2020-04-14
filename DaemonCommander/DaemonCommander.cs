using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
				var resp = new byte[1024];
				daemonSocket.Connect(daemonSocketEp);
				var cmd = "{\"command\":\"status\"}";
				byte[] msg = Encoding.ASCII.GetBytes(cmd);
				daemonSocket.Send(msg);
				daemonSocket.Receive(resp);
				daemonSocket.Close();
				return Encoding.ASCII.GetString(resp);
			}
			catch (Exception e)
			{
				throw e;
			}
		} 
	}
}
