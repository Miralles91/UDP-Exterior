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

namespace UDP_Exterior
{
    public partial class UDP : Form
    {
        GestionRSA.GestionRSA _GestionRSA;
        public UDP()
        {
            InitializeComponent();
            //Thread prova = new Thread(escoltarClient);
            //prova.Start();
        }

        private void butsend_Click(object sender, EventArgs e)
        {
            Biblioteca_UDP.clientes client = new Biblioteca_UDP.clientes();
            client.MsgSend(txtmessage.Text);
            txtmessage.Text = string.Empty;
        }

        public void escoltarClient()
        {
            Biblioteca_UDP.Servidor server = new Biblioteca_UDP.Servidor();

            while (true)
            {
                string mensaje = server.serverThread();

                if (labhost.InvokeRequired)
                {
                    labhost.Invoke((MethodInvoker)delegate { labhost.Text = mensaje; });
                }
                else
                {
                    labhost.Text = mensaje;
                }
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread prova = new Thread(escoltarClient);
            prova.Start();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selecciona clave Publica");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Llave publica en XML (+.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Stream tempStream;
                if((tempStream = openFileDialog.OpenFile()) != null)
                {
                    //GestionRSA.CreateAndWriteRSAKeys();
                    //GestionRSA.GuardarPublicKeyEnDB();
                    string xmlFile = new StreamReader(tempStream).ReadToEnd();
                    byte[] encriptedData = _GestionRSA.EncriptarRSA(txtmessage.Text, xmlFile);
                    Biblioteca_UDP.clientes client = new Biblioteca_UDP.clientes();
                    client.MsgSend(encriptedData);
                }
            }
        }

        private void btnDesencrypt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione clave Privada");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Llave publica en XML (+.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                Stream tempStream;
                if ((tempStream = openFileDialog.OpenFile()) != null)
                {
                    //GestionRSA.CreateAndWriteRSAKeys();
                    //GestionRSA.GuardarPublicKeyEnDB();
                    string xmlFile = new StreamReader(tempStream).ReadToEnd();
                    byte[] DencriptedData = _GestionRSA.DesencriptarRSA(txtmessage.Text, xmlFile);
                    Biblioteca_UDP.clientes client = new Biblioteca_UDP.clientes();
                    client.MsgSend(DencriptedData);
                }
            }
        }

        private void UDP_Load(object sender, EventArgs e)
        {
            _GestionRSA = new GestionRSA.GestionRSA();
            _GestionRSA.CreateAndWriteRSAKeys();
            _GestionRSA.GuardarPublicKeyEnDB();
        }
    }
}
