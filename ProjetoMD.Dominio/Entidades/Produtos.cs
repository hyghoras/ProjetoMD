using System.Collections.Generic;

namespace ProjetoMD.Dominio.Entidades
{
    public class Produtos
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public int Quantidade { get; set; }

        public virtual ICollection<Saidas> Saidas { get; set; }
    }
}
