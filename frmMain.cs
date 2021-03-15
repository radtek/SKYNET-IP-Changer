using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.Globalization;
using System.Management;
using System.Runtime.CompilerServices;
using NetManager;
using System.Text.RegularExpressions;

namespace lol
{
    public partial class frmMain : Form
    {
        private bool serverRunning;
        public static frmMain frm;
        public string IP { get; private set; }
        Thread search;
        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;  //Para permitir acceso a los subprocesos
            frm = this;

            RegistrySettings.Initialice();
            RegistrySettings.LoadSettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetMyData();

            //NetworkConfigurator.GetData();
        }
        private void GetMyData()
        {
        }




        private void btnCambiar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NetworkAdapterConfiguration net = new NetworkAdapterConfiguration();
            net.SetDNSDomain("10.31.0.8");
            MessageBox.Show(net.DHCPEnabled.ToString());

            LogMessage("Esto es una prueba");
        }

        private StringBuilder stringBuilder;

        public void LogMessage(string message)
        {
            stringBuilder = new StringBuilder();
            stringBuilder.Append(DateTime.Now.ToString("yyyy.MM.dd "));
            stringBuilder.Append(Application.ProductName + " ");
            stringBuilder.Append(Application.ProductVersion);
            stringBuilder.AppendLine(string.Empty);
            stringBuilder.AppendLine("Official Site: ");
            stringBuilder.AppendLine("http://forums.mydigitallife.info/forums/51-KMS-tools");
            stringBuilder.AppendLine("KMSpico v10.2.0");
            stringBuilder.AppendLine(message);
            message = stringBuilder.ToString();
            MessageBox.Show(message);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (!IPAddress.TryParse(txtIP.Text, out IPAddress address1))
            {
                MessageBox.Show("La Dirección IP especificada no es válida, por favor... corríjela." + Environment.NewLine + txtIP.Text);
                return;
            }
            if (!IPAddress.TryParse(txtMask.Text, out IPAddress address2))
            {
                MessageBox.Show("La Máscara de subred especificada no es válida, por favor... corríjela." + Environment.NewLine + txtMask.Text);
                return;
            }
            if (!string.IsNullOrEmpty(txtGateway.Text) && !IPAddress.TryParse(txtGateway.Text, out IPAddress address3))
            {
                MessageBox.Show("La Puerta de enlace especificada no es válida, por favor... corríjela." + Environment.NewLine + txtGateway.Text);
                return;
            }
            if (!string.IsNullOrEmpty(txtDNS.Text) && !IPAddress.TryParse(txtDNS.Text, out IPAddress address4))
            {
                MessageBox.Show("El Servidor DNS especificado no es válido, por favor... corríjelo." + Environment.NewLine + txtDNS.Text);
                return;
            }
            NetworkConfigurator.SetIP(txtIP.Text, txtMask.Text);
            NetworkConfigurator.SetGateway(txtGateway.Text);

            if (!string.IsNullOrEmpty(txtDNS.Text))
            {
                NetworkConfigurator.SetDNS(txtDNS.Text);
            }

            RegistrySettings.SaveSettings();
        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {
            NetworkConfigurator.SetDHCP();
            NetworkConfigurator.UnsetDNS();
            
            RegistrySettings.SaveSettings();
        }
        internal static bool IsValidIp(string ip)
        {
            return IPAddress.TryParse(ip, out IPAddress address);
        }

        private void TxtIP_TextChanged(object sender, EventArgs e)
        {
            if (IsValidIp(txtIP.Text))
            {
                txtIPColor.BackColor = Color.FromArgb(17, 199, 255);
            }
            else
                txtIPColor.BackColor = Color.Red;
        }

        private void TxtMask_TextChanged(object sender, EventArgs e)
        {
            if (IsValidIp(txtMask.Text))
            {
                txtMaskColor.BackColor = Color.FromArgb(17, 199, 255);
            }
            else
                txtMaskColor.BackColor = Color.Red;
        }

        private void TxtGateway_TextChanged(object sender, EventArgs e)
        {
            if (IsValidIp(txtGateway.Text))
            {
                txtGatewayColor.BackColor = Color.FromArgb(17, 199, 255);
            }
            else
                txtGatewayColor.BackColor = Color.Red;
        }

        private void TxtDNS_TextChanged(object sender, EventArgs e)
        {

            if (IsValidIp(txtDNS.Text))
            {
                txtDNSColor.BackColor = Color.FromArgb(17, 199, 255);
            }
            else
            {
                txtDNSColor.BackColor = Color.Red;
                
            }
        }

        private void TxT_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
