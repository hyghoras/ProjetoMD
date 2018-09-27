using ProjetoMD.Dominio.Interfaces.Repositorios;
using ProjetoMD.Persistencia.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMD.Persistencia.Repositorios
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity>
        where TEntity : class
    {

        protected ProjetoMDContexto bd = new ProjetoMDContexto();

        public void Adicionar(TEntity objeto)
        {
            bd.Set<TEntity>().Add(objeto);
            bd.SaveChanges();
        }

        public void Alterar(TEntity objeto)
        {
            bd.Entry(objeto).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
        }

        public TEntity ConsultaporId(int Id)
        {
            return bd.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> ConsultarTodos()
        {
            return bd.Set<TEntity>().ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntity objeto)
        {
            bd.Set<TEntity>().Remove(objeto);
            bd.SaveChanges();
        }
    }
}
