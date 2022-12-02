using Busines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
    public abstract class RepositorioVeiculos<Tveiculo> where Tveiculo : Entity
    {
        protected List<Tveiculo> _veiculos;

        public RepositorioVeiculos()
        {
            _veiculos = new List<Tveiculo>();
        }

        public virtual void InserirVeiculo(Tveiculo veiculo)
        {
            _veiculos.Add(veiculo);
        }
        public virtual Tveiculo ObterVeiculo(int codigo)
        {
            return _veiculos.FirstOrDefault(x => x.Codigo == codigo);
        }
        public virtual List<Tveiculo> ObterListaVeiculo()
        {
            return _veiculos;
        }
        public virtual int ObterQuantidade()
        {
            return _veiculos.Count();
        }
    }
}
