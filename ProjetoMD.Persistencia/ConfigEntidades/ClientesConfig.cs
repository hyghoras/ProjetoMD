using ProjetoMD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMD.Persistencia.ConfigEntidades
{
    public class ClientesConfig : EntityTypeConfiguration<Clientes>
    {
        public ClientesConfig()
        {
            HasKey(u => u.Id);
            Property(u => u.Nome).IsRequired().HasMaxLength(50);
            Property(u => u.Ativo).IsRequired();
            Property(u => u.Nome).IsRequired().HasMaxLength(50);
            Property(u => u.CPF).IsRequired();
        }
    }
}
