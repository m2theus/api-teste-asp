using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Dtos.Pessoa
{
    public class PessoaDto
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Documento { get; set; }

        public int Idade { get; set; }

        public string Profissao { get; set; }
    }
}
