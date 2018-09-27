using ProjetoMD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMD.Persistencia.ConfigEntidades
{
    public class ProdutosConfig : EntityTypeConfiguration<Produtos>
    {
        public ProdutosConfig()
        {
            HasKey(u => u.Id);
            Property(u => u.Ativo).IsRequired();
            Property(u => u.Descricao).IsRequired().HasMaxLength(50);
            Property(u => u.Valor).IsRequired();
            Property(u => u.Quantidade).IsRequired();
        }
    }
}

