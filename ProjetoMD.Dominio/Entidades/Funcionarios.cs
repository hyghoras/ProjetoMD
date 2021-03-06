﻿using System.Collections.Generic;

namespace ProjetoMD.Dominio.Entidades
{
    public class Funcionarios
    {
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Salario { get; set; }
        public string Funcao { get; set; }
        public int Numero { get; set; }
        public Enderecos Enderecos { get; set; }

        public virtual ICollection<Saidas> Saidas { get; set; }
    }
}
