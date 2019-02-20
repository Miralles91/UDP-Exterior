using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UDP
{
    public class clientes
    {
        #region Instancias
        UdpClient _server = new UdpClient();
        #endregion

        #region Funciones
        public void MsgSend(string txtmessage)
        {
            //Dirrección
            IPAddress Server_Ip = IPAddress.Parse("172.17.20.186");
            _server.Connect(Server_Ip, 11000);
            //Mensaje ha enviar
            Byte[] senddata = Encoding.ASCII.GetBytes(txtmessage);
            //Enviar codi confirmacio despres de desencriptar i encriptarlo

            _server.Send(senddata, senddata.Length);
        }
        public void MsgSend(byte[] txtmessage)
        {
            //Dirrección
            IPAddress Server_Ip = IPAddress.Parse("172.17.20.186");
            _server.Connect(Server_Ip, 11000);
            //Mensaje ha enviar
            //Byte[] senddata = Encoding.ASCII.GetBytes(txtmessage);
            //Enviar codi confirmacio despres de desencriptar i encriptarlo

            _server.Send(txtmessage, txtmessage.Length);
        }
        #endregion
    }
}
