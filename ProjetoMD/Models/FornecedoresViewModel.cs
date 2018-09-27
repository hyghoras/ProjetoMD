using ProjetoMD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoMD.MVC.Models
{
    public class FornecedoresViewModel
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

        [Required(ErrorMessage = "O campo E-mail é obrigatório")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Telefone é obrigatório")]
        [MaxLength(12, ErrorMessage = "Máximo de 12 caracteres")]
        [MinLength(11, ErrorMessage = "Mínimo de 11 caracteres")]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo CNPJ é obrigatório")]
        [MaxLength(14, ErrorMessage = "Máximo de 14 caracteres")]
        [MinLength(11, ErrorMessage = "Mínimo de 11 caracteres")]
        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }

        public int Numero { get; set; }

        public Enderecos Enderecos { get; set; }

        public virtual ICollection<Saidas> Saidas { get; set; }
    }
}