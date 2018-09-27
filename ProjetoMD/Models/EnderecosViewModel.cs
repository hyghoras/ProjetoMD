using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoMD.MVC.Models
{
    public class EnderecosViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        //[Required(ErrorMessage = "O campo Numero é obrigatório")]
        //[MaxLength(4, ErrorMessage = "Máximo de 4 caracteres")]
        //[MinLength(1, ErrorMessage = "Mínimo de 1 caracteres")]
        //[DisplayName("Numero")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        [MaxLength(8, ErrorMessage = "Máximo de 8 caracteres")]
        [MinLength(8, ErrorMessage = "Mínimo de 8 caracteres")]
        [DisplayName("CEP")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo Estado é obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Estado")]
        public string Estado { get; set; }
    }
}