using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDomain.Entities
{
    public class Artista
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

        private IEnumerable<Musica> musicas;
        public IList<Musica> Musicas
        {
            set { musicas = value; }
        }

        private IEnumerable<Album> albuns;
        public IList<Album> Albuns
        {
            set { albuns = value; }
        }

        public Artista()
        {
            this.musicas = new List<Musica>();
            this.albuns = new List<Album>();
        }
    }
}
