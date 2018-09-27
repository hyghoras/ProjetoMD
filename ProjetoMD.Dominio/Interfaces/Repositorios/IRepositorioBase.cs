using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMD.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity objeto);

        TEntity ConsultaporId(int Id);

        IEnumerable<TEntity> ConsultarTodos();

        void Alterar(TEntity obejto);

        void Remover(TEntity objeto);

        void Dispose();
    }
}
