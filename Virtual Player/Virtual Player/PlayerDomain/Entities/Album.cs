using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDomain.Entities
{
    public class Album
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string anoLancamento;
        public string AnoLancamento
        {
            get { return anoLancamento; }
            set { anoLancamento = value; }
        }

        private string foto;
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        private IEnumerable<Musica> musicas;
        public IList<Musica> Musicas
        {
            set { musicas = value; }
        }

        private IEnumerable<Artista> artistas;
        public IList<Artista> Artistas
        {
            set { artistas = value; }
        }

        public Album()
        {
            this.musicas = new List<Musica>();
            this.artistas = new List<Artista>();
        }
    }
}
