using ProjetoMD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMD.Persistencia.ConfigEntidades
{
    public class SaidasConfig : EntityTypeConfiguration<Saidas>
    {
        public SaidasConfig()
        {
            HasKey(u => u.Id);
            Property(u => u.Quantidade).IsRequired();
        }
    }
}
