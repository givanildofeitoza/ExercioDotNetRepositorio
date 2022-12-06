using Busines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
    public abstract class RepositorioVeiculos<T> where T : Veiculo
    {
        protected List<T> _veiculos;

        public RepositorioVeiculos()
        {
            _veiculos = new List<T>();
        }

        public virtual void InserirVeiculo(T veiculo)
        {
            _veiculos.Add(veiculo);
        }
        public virtual T ObterVeiculo(int codigo)
        {
            return _veiculos.FirstOrDefault(x => x.Codigo == codigo);
        }
        public virtual List<T> ObterListaVeiculo()
        {
            return _veiculos;
        }
        public virtual int ObterQuantidade()
        {
            return _veiculos.Count();
        }
    }
}
