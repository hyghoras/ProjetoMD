using ProjetoMD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMD.Persistencia.ConfigEntidades
{
    public class FornecedoresConfig : EntityTypeConfiguration<Fornecedores>
    {
        public FornecedoresConfig()
        {
            HasKey(u => u.Id);
            Property(u => u.Ativo).IsRequired();
            Property(u => u.Nome).IsRequired().HasMaxLength(50);
            Property(u => u.Email).IsRequired().HasMaxLength(50);
            Property(u => u.Telefone).IsRequired().HasMaxLength(50);
            Property(u => u.CNPJ).IsRequired();
        }
    }
}
