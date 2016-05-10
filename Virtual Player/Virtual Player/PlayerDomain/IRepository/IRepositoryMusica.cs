using PlayerDomain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDomain.IRepository
{
    public interface IRepositoryMusica
    {
        List<Musica> RetornarMusicas(string nome);
    }
}
