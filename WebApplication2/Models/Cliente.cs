using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestaoComercial.Models
{
    public class Cliente
    {


        [Key]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        [StringLength(255, ErrorMessage = "Maximo 255 caracteres")]
        public string NomeCompletoRazaoSocial { get; set; }

        [Display(Name = "Nome Fantasia")]
        [StringLength(255, ErrorMessage = "Maximo 255 caracteres")]
        public string ApelidoNomeFantasia { get; set; }

        [Required]
        [Display(Name = "CPF/CNPJ")]
        [StringLength(15, ErrorMessage = "Maximo 15 caracteres")]
        public string CPFCNJP { get; set; }


    }
}