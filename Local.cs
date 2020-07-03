using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minefield
{
	public class Local
	{
		public Local(Label lblUserName)
		{
			string localIP;
			using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
			{
				socket.Connect("8.8.8.8", 65530);
				IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
				localIP = endPoint.Address.ToString();
			}

			string strComputerName = Environment.MachineName.ToString();
			string strUserName = Environment.UserName.ToString();


			string nick = lblUserName.Text;
		}
	}
}