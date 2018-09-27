using ProjetoMD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoMD.MVC.Models
{
    public class ProdutosViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Ativo é obrigatório")]
        [DisplayName("Ativo")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        //[MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Valor")]
        public float Valor { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório")]
        //[MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        //[MinLength(2, ErrorMessage = "Mínimo de 2 caracteres")]
        [DisplayName("Quantidade")]
        public int Quantidade { get; set; }

       

       
        public virtual ICollection<Saidas> Saidas{ get; set; }
    }
}