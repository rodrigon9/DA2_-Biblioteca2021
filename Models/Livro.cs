using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2__aplicação.Models
{
    public class Livro
    {
        private int _identificacao;
        private string _titulo;
        private string _autor;
        private string _editora;
        private int _totalpaginas;
        private string _capa;
        private bool _emprestado;
        private int _emprestadopor;

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

        public string Titulo
        {
            get
            {
                return _titulo;
            }

            set
            {
                _titulo = value;
            }
        }

        public string Autor
        {
            get
            {
                return _autor;
            }
            set
            {
                _autor = value;
            }
        }

        public string Editora
        {
            get
            {
                return _editora;
            }
            set
            {
                _editora = value;
            }
        }

        public int TotalPaginas
        {
            get
            {
                return _totalpaginas;
            }

            set
            {
                _totalpaginas = value;
            }
        }

        public string Capa
        {
            get
            {
                return _capa;
            }
            set
            {
                _capa = value;
            }    
        }

        public bool Emprestado
        {
            get
            {
                return _emprestado;
            }
            set
            {
                _emprestado = value;
            }
        }

        public int EmprestadoPor
        {
            get
            {
                return _emprestadopor;
            }

            set
            {
                _emprestadopor = value;
            }
        }
        public Livro(int _identificacao, string _titulo, string _autor, string _editora, int _totalpaginas, string _capa, bool _emprestado, int _emprestadopor) 
        {
           _identificacao = Identificacao;
            _titulo = Titulo;
            _autor = Autor;
            _editora = Editora;
            _totalpaginas = TotalPaginas;
            _capa = Capa;
            _emprestado = Emprestado;
            _emprestadopor = EmprestadoPor;

        }

    }
}
