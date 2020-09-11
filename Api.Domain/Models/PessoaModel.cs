using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class PessoaModel
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _nome;

        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private String _documento;

        public String Documento
        {
            get { return _documento; }
            set { _documento = value; }
        }

        private String _email;

        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private String _profissao;

        public String Profissao
        {
            get { return _profissao; }
            set { _profissao = value; }
        }


        private String _idade;

        public String Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }


    }
}
