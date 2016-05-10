using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db4objects.Db4o;
using PlayerDomain.Entities;
using PlayerDomain.IRepository;
using System.IO;

namespace PlayerRepository
{
    public class RepositoryMusica : IRepositoryMusica
    {
        public List<Musica> RetornarMusicas(string nome)
        {
            List<Musica> musicas = new List<Musica>();
            
            foreach(var arquivo in Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "Musicas"), String.Format("*{0}*.*", nome)))
            {
                musicas.Add(new Musica() { CaminhoMusica = arquivo, NomeArtista = nome, NomeMusica = arquivo });
            }

            return musicas;

        }
    }
}
