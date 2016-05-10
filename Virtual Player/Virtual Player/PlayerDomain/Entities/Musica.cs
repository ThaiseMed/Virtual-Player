using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDomain.Entities
{
    public class Musica
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nomeMusica;
        public string NomeMusica
        {
            get { return nomeMusica; }
            set { nomeMusica = value; }
        }

        private TimeSpan tempoDuracao;
        public TimeSpan TempoDuracao
        {
            get { return tempoDuracao; }
            set { tempoDuracao = value; }
        }

        private string caminhoMusica;
        public string CaminhoMusica
        {
            get { return caminhoMusica; }
            set { caminhoMusica = value; }
        }

        private string nomeArtista;
        public string NomeArtista
        {
            get { return nomeArtista; }
            set { nomeArtista = value; }
        }

        private string nomeAlbum;
        public string NomeAlbum
        {
            get { return nomeAlbum; }
            set { nomeAlbum = value; }
        }

        private string anoLancamentoAlbum;
        public string AnoLancamentoAlbum
        {
            get { return anoLancamentoAlbum; }
            set { anoLancamentoAlbum = value; }
        }

        private string fotoAlbum;
        public string FotoAlbum
        {
            get { return fotoAlbum; }
            set { fotoAlbum = value; }
        }

        public byte[] Arquivo
        {
            get
            {
                return arquivo;
            }

            set
            {
                arquivo = value;
            }
        }

        private byte[] arquivo;




        //private IEnumerable<Artista> artistas;
        //public IList<Artista> Artistas
        //{
        //    set { artistas = value; }
        //}

        //private IEnumerable<Album> albuns;
        //public IList<Album> Albuns
        //{
        //    set { albuns = value; }
        //}

        public Musica()
        {
            //this.artistas = new List<Artista>();
            //this.albuns = new List<Album>();
        }
    }
}
