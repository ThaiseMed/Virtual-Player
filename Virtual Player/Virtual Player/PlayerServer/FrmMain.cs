using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using PlayerDomain.Entities;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace PlayerServer
{
    public partial class FrmMain : Form
    {
        private SerialPort sp = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            IniciarPorta();
        }

        private void IniciarPorta()
        {
            sp = new SerialPort("COM6", 19200, Parity.None, 8, StopBits.One);
            sp.Handshake = Handshake.None;
            sp.DataReceived += Sp_DataReceived;
            try
            {
                sp.Open();
                sp.DiscardOutBuffer();
                sp.DiscardInBuffer();
                tstbStatus.Text = "Conectado";
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Erro ao conectar a PORTA COM! {0}", ex.Message));
            }
        }

        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var sp = (SerialPort)sender;
            Thread.Sleep(500);
            string comando = sp.ReadExisting();

            TratarComando(comando);
        }

        private void TratarComando(string comando)
        {
            string[] separador = new string[] { "|" };
            string[] comandos = comando.Split(separador, StringSplitOptions.RemoveEmptyEntries);

            Player player = new Player();

            switch (Convert.ToInt32(comandos[0]))
            {
                case 1:
                    this.Invoke((MethodInvoker)delegate
                   {
                       List<Musica> musicas = player.Procurar(comandos[1]);
                       sp.Write(String.Format("{0}|{1}", 1, JsonConvert.SerializeObject(musicas)));
                   });
                    break;
                case 2:
                    this.Invoke((MethodInvoker)delegate
                    {
                        sp.Write(comandos[1]);
                    });
                    break;
            }
        }
        private void AtualizarLista(string texto)
        {
            lstCommands.Items.Add(String.Format("[{0}] - {1}", DateTime.Now.ToLocalTime(), texto));
            lstCommands.Invalidate();
        }
    }
}
