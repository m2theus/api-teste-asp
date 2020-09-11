using System;

namespace Domain.Entities
{
    public class PessoaEntity : BaseEntity
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Documento { get; set; }

        public int Idade { get; set; }

        public string Profissao { get; set; }
    }
}
