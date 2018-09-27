using ProjetoMD.Dominio.Entidades;
using ProjetoMD.Persistencia.ConfigEntidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoMD.Persistencia.Contexto
{
    public class ProjetoMDContexto : DbContext
    {
        public ProjetoMDContexto()
            : base("ProjetoMD")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new CategoriaConfig());
            modelBuilder.Configurations.Add(new ClientesConfig());
            modelBuilder.Configurations.Add(new EnderecosConfig());
            modelBuilder.Configurations.Add(new FornecedoresConfig());
            modelBuilder.Configurations.Add(new FuncionariosConfig());
            modelBuilder.Configurations.Add(new ProdutosConfig());
            modelBuilder.Configurations.Add(new SaidasConfig());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }
        public DbSet<Funcionarios> Funcionarios { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Saidas> Saidas { get; set; }
    }
}
