using GestionRSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Biblioteca_UDP
{
    public class Servidor
    {
        #region Instancias
        UdpClient server = new UdpClient(15000);
        IPEndPoint client = null;
        #endregion

        #region server
        public byte[] serverThread()
        {
             Byte[] receiveBytes = server.Receive(ref client);

            return receiveBytes;
        }
        #endregion
    }
}
