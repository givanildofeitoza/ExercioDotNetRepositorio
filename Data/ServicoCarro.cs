using Busines.Models;
using Data.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ServicoCarro : RepositorioVeiculos<Carro>
    {
        public void delete(int id)
        {
            var cr = _veiculos.FirstOrDefault(x => x.Codigo == id);
            _veiculos.Remove(cr);
        }
    }
}
