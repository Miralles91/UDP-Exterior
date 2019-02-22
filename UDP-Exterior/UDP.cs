using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Net;

namespace UDP_Exterior
{
    public partial class UDP : Form
    {
        string _codeShip = string.Empty;
        bool _IsConfirmat = false;
        GestionRSA.GestionRSA _GestionRSA;
        
        public UDP()
        {
            InitializeComponent();
        }

        private void butsend_Click(object sender, EventArgs e)
        {
            string codiAcces = nomNau(_codeShip, _IsConfirmat);
            Biblioteca_UDP.clientes client = new Biblioteca_UDP.clientes();
            client.MsgSend(codiAcces);
            txtmessage.Text = string.Empty;
        }

        public void escoltarClient()
        {

            Biblioteca_UDP.Servidor server = new Biblioteca_UDP.Servidor();
            IPEndPoint client = null;
            string mensaje = string.Empty;

            while (true)
            {
                byte[] receiveBytes = server.serverThread();//era un string

                string xmlFile = _GestionRSA.PrivateKey;
                byte[] DencriptedData = _GestionRSA.DesencriptarRSA(receiveBytes, xmlFile);//
                string Descodi = Encoding.ASCII.GetString(DencriptedData);//
                string returnData = Encoding.ASCII.GetString(receiveBytes);//

                if (labCode.InvokeRequired)
                {
                    labCode.Invoke((MethodInvoker)delegate { labCode.Text = Descodi; });
                    CodiConfirmat(Descodi);
                }
                else
                {
                    labCode.Text = Descodi;
                }

            }
        }

        public void CodiConfirmat(string descCodi)
        {
            string query = "";
            bool confirmat = false;
            string codeShip = "";
            if (descCodi.Length == 28)
            {
                string dateTime = (descCodi.Substring(4, 4) + "/" + descCodi.Substring(0, 2) + "/" + descCodi.Substring(2, 2)).Trim();
                codeShip = descCodi.Substring(8, 8);
                _codeShip = codeShip;
                string codeDelivery = descCodi.Substring(16, 12);
                query = "SELECT * FROM DeliveryData WHERE(CodeDelivery = '" + codeDelivery + "') AND (DeliveryDate = CONVERT(DATETIME, '" + dateTime + "', 102)) AND (SpaceShip = '" + codeShip + "')";
                ConnectionClass.ConnectionClass CClassDB = new ConnectionClass.ConnectionClass();
                var dts = CClassDB.PortaPerConsulta(query);
                try
                {
                    var DeliveryDate = dts.Tables[0].Rows[0].ItemArray[2].ToString().Substring(0, 10);
                    DeliveryDate = DeliveryDate.Substring(6, 4) + "/" + DeliveryDate.Substring(3, 2) + "/" + DeliveryDate.Substring(0, 2);

                    var SpaceShip = dts.Tables[0].Rows[0].ItemArray[5].ToString();

                    var CodeDeliver = dts.Tables[0].Rows[0].ItemArray[1].ToString();

                    if (dateTime.Equals(DeliveryDate) && codeShip.Equals(SpaceShip) && codeDelivery.Equals(CodeDeliver))
                    {
                        MessageBox.Show("Codi correcte");
                        confirmat = true;
                        _IsConfirmat = true;
                    }
                    else {
                        MessageBox.Show("Codi Incorrecte");
                    }

                }catch{
                    MessageBox.Show("Codi Incorrecte");
                }

            } else
            {
                MessageBox.Show("Codi totalment incorrecte");
            }

            nomNau(codeShip,confirmat);
        }

        public string nomNau(string codeShip, bool confirmat)
        {
            string codi = "";
            if (confirmat) {
                codi = codeShip + "AG";
            }
            else {
                codi = codeShip + "AD";
            }
            return codi;
        }

        private void UDP_Load(object sender, EventArgs e)
        {
            Thread prova = new Thread(escoltarClient);
            prova.Start();

            _GestionRSA = new GestionRSA.GestionRSA();
        }

        private void btnKeyPrivada_Click(object sender, EventArgs e)
        {
            _GestionRSA.CreateAndWriteRSAKeys();
            _GestionRSA.GuardarPublicKeyEnDB();
        }
    }
}
