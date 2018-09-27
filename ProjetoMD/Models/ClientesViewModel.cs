using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using ProjetoMD.Dominio.Entidades;

namespace ProjetoMD.MVC.Models
{
    public class ClientesViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 12 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de 11 caracteres")]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 14 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de 11 caracteres")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        public int Numero { get; set; }

        public Enderecos Enderecos { get; set; }
    }
}