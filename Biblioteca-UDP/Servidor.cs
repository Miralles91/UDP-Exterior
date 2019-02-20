using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca_UDP
{
    public class Servidor
    {
        #region Instancias
        UdpClient server = new UdpClient(15000);
        IPEndPoint client = null;
        string mensaje = string.Empty;
        #endregion
        
        #region server
        public string serverThread()
        {           
             //Array que coge los valores recibimos del cliente
             Byte[] receiveBytes = server.Receive(ref client);
             //Traducimos array
             string returnData = Encoding.ASCII.GetString(receiveBytes);
            //Desencriptar codi

             mensaje = client.Address.ToString() + ": " + returnData.ToString();

             return mensaje;
        }
        #endregion
    }
}
