using ProjetoMD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoMD.MVC.Models
{
    public class SaidasViewModel
    {
        [Key]
        public int Id { get; set; }

        public int IdProduto { get; set; }
        public int IdFuncionario { get; set; }
        public string Nome_Funcionario { get; set; }
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório")]
        //[MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

    }
}