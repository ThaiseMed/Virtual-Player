using Newtonsoft.Json;
using PlayerDomain.Entities;
using PlayerRepository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WMPLib;

namespace PlayerClient
{
    /// <summary>
    /// Interaction logic for Busca.xaml
    /// </summary>
    public partial class Busca : Page
    {

        SerialPort sp = null;
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Busca()
        {
            InitializeComponent();
            IniciarPorta();
        }

        private void IniciarPorta()
        {
            sp = new SerialPort("COM5", 19200, Parity.None, 8, StopBits.One);
            sp.Handshake = Handshake.None;
            sp.DataReceived += Sp_DataReceived;
            try
            {
                sp.Open();
                sp.DiscardOutBuffer();
                sp.DiscardInBuffer();
                //tstbStatus.Text = "Conectado";
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
            TratarComando(sp.ReadExisting());
        }

        private void TratarComando(string comando)
        {
            string[] separador = new string[] { "|" };
            string[] comandos = comando.Split(separador, StringSplitOptions.RemoveEmptyEntries);

            if (comandos.Length == 2)
            {
                switch (Convert.ToInt32(comandos[0]))
                {
                    case 1:
                        this.Dispatcher.Invoke(() =>
                        {
                            var musicas = JsonConvert.DeserializeObject<List<Musica>>(comandos[1]);
                            foreach (var musica in musicas)
                            {
                                string[] splitMusica = musica.NomeMusica.Split('\\');
                                int i = splitMusica.Length;
                                musica.NomeMusica = splitMusica[i - 1];
                            }
                            grdMusicas.ItemsSource = musicas.ToList();
                        });
                        break;
                }
            }
            else
            {
                this.Dispatcher.Invoke(() =>
                {
                    //NavigationService navigation = NavigationService.GetNavigationService(this);
                    //Playlist playlist = new Playlist(new Uri(comandos[0].ToString(), UriKind.Absolute));
                    //navigation.Navigate(playlist);

                    player.openPlayer(new Uri(comandos[0].ToString(), UriKind.Absolute).ToString());
                });
            }


        }

        private void btnBusca_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeBusca.Text))
                MessageBox.Show("Digite no campo de texto a sua pesquisa");
            else
                sp.Write(String.Format("{0}|{1}", 1, txtNomeBusca.Text));
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            Musica musica = grdMusicas.SelectedItem as Musica;
            sp.Write(String.Format("{0}|{1}", 2, musica.CaminhoMusica));
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }
    }
}
