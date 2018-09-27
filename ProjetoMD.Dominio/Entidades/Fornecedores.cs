namespace ProjetoMD.Dominio.Entidades
{
    public class Fornecedores
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CNPJ { get; set; }
        public int Numero { get; set; }
        public Enderecos Enderecos { get; set; }
    }
}
