using PlayerDomain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WMPLib;


namespace PlayerClient
{
    /// <summary>
    /// Interaction logic for Playlist.xaml
    /// </summary>
    public partial class Playlist : Page
    {
        Uri uriMusica;
        WindowsMediaPlayer player;
        public Playlist(Uri uriMusica)
        {
            this.uriMusica = uriMusica;
            InitializeComponent();
            Play();
        }

        private void Play()
        {
            player = new WindowsMediaPlayer();
            player.openPlayer(uriMusica.ToString());            
        }
    }
}
