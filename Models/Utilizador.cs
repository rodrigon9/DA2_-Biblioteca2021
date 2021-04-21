using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2__aplicação.Models
{
    public class Utilizador
    {
        private int _identificacao;
        private string _nome;
        private string _email;
        private string _password;
        private string _fotoperfil;

        public int Identificacao
        {
            get
            {
                return _identificacao;
            }
            set
            {
                _identificacao = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;

            }
            set
            {
                _email = value;
            }
        }

        public string Password
        {
            get
            {
                return Password;
            }
            set
            {
                _password = value;
            }
        }

        public string FotoPerfil
        {
            get
            {
                return _fotoperfil;
            }
            set
            {
                _fotoperfil = value;
            }
        }
    }
}
