namespace ProjetoMD.Dominio.Entidades
{
    public class Saidas
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }

        public int IdProduto { get; set; }
        public int IdFuncionario { get; set; }
        public string Nome_Funcionario { get; set; }
        public int IdCliente { get; set; }

        public virtual Produtos Produtos { get; set; }
        public virtual Funcionarios Funcionarios { get; set; }
        public virtual Clientes Clientes { get; set; }
    }
}
