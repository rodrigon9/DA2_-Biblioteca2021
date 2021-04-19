using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2__aplicação.Models
{
    public class Livro
    {
        private string m_nome;
        private string m_autor;
        private string m_editora;
        private int m_ano;

        public string Nome
        {
            get
            {
                return m_nome;
            }
            set
            {
                m_nome = value;
            }
        }

        public string Autor
        {
            get
            {
                return m_autor;
            }

            set
            {
                m_autor = value;
            }
        }

        public string Editora
        {
            get
            {
                return m_editora;
            }
            set
            {
                m_editora = value;
            }
        }

        public int Ano
        {
            get
            {
                return m_ano;
            }
            set
            {
                m_ano = value;
            }
        }

        public Livro(string m_nome, string m_Autor, string m_editora, int m_ano)
        {
            m_nome = Nome;
            m_autor = Autor;
            m_editora = Editora;
            m_ano = Ano;
        }

    }
