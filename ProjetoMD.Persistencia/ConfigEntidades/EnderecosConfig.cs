using ProjetoMD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMD.Persistencia.ConfigEntidades
{
    public class EnderecosConfig : EntityTypeConfiguration<Enderecos>
    {
        public EnderecosConfig()
        {
            HasKey(u => u.Id);
            Property(u => u.Nome).IsRequired().HasMaxLength(50);
            Property(u => u.Numero).IsRequired();
            Property(u => u.Bairro).IsRequired().HasMaxLength(50);
            Property(u => u.CEP).IsRequired();
            Property(u => u.Cidade).IsRequired().HasMaxLength(50);
            Property(u => u.Estado).IsRequired().HasMaxLength(50);
        }
    }
}