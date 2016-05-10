using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerDomain.Entities;
using PlayerRepository;
using System.IO;

namespace PlayerServer
{
    public class Player
    {
       
        public List<Musica> Procurar(string texto)
        {
            RepositoryMusica repository = new RepositoryMusica();
            List<Musica> musicas = repository.RetornarMusicas(texto);
            return musicas;
        }
    }
}
