using ProjetoMD.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMD.Persistencia.ConfigEntidades
{
    public class FuncionariosConfig : EntityTypeConfiguration<Funcionarios>
    {
        public FuncionariosConfig()
        {
            HasKey(u => u.Id);
            Property(u => u.Ativo).IsRequired();
            Property(u => u.Nome).IsRequired().HasMaxLength(50);
            Property(u => u.Email).IsRequired().HasMaxLength(50);
            Property(u => u.Telefone).IsRequired().HasMaxLength(50);
            Property(u => u.CPF).IsRequired();
            Property(u => u.Salario).IsRequired();
            Property(u => u.Funcao).IsRequired().HasMaxLength(50);
        }
    }
}
