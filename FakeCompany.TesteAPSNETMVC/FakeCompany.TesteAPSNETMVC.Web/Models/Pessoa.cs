using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FakeCompany.TesteAPSNETMVC.Web.Models
{
    public class Pessoa
    { 

        [MaxLength(50, ErrorMessage = "O nome pode ter no máximo 50 caracteres")]
        [MinLength(3, ErrorMessage = "O nome deve ter no minimo 3 caracteres")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [DisplayName("Nome: ")]
        public string Nome { get; set; }

        
        [DisplayName("Idade: ")]
        public int? Idade { get; set; }

        [MaxLength(100, ErrorMessage = "O endereço pode ter no máximo 100 caracteres")]
        [MinLength(10, ErrorMessage = "O endereco deve ter no minimo 10 caracteres")]
        [Required(ErrorMessage = "O Endereço é obrigatório")]
        [DisplayName("Endereço: ")]
        public string Endereco { get; set; }

        [MaxLength(20, ErrorMessage = "O email pode ter no máximo 20 caracteres")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Por favor insira um e-mail valido")]
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [DisplayName("E-mail: ")]
        public string Email { get; set; }

    }
}
