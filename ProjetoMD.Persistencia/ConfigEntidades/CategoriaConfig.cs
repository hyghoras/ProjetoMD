using ProjetoMD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMD.Persistencia.ConfigEntidades
{
    public class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
        HasKey(u => u.Id);
        Property(u => u.Ativo).IsRequired();
        Property(u => u.Descricao).IsRequired().HasMaxLength(50);
        }
    }
}
