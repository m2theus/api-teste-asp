using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Dtos.Pessoa
{
    public class PessoaDtoCreate
    {
        [Required(ErrorMessage = "Nome é campo obrigatório")]
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email é campo obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail com formato inválido")]
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo {1} caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Documento é campo obrigatório")]
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo {1} caracteres")]
        public string Documento { get; set; }

        [Required(ErrorMessage = "NIdadeome é campo obrigatório")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Profissao é campo obrigatório")]
        [StringLength(100, ErrorMessage = "Profissao deve ter no máximo {1} caracteres")]
        public string Profissao { get; set; }
    }
}
