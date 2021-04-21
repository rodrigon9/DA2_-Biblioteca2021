using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2__aplicação.Models
{
    public static class Repositorio
    {
        private static List<Livro> repositorioLivros = new List<Livro>();
        private static List<Utilizador> Utilizador = new List<Utilizador>();     //Criar lista para user no geral & array para user com livros ??
        public static List<Livro> RepositorioDeLivros
        {
            get
            {
                return repositorioLivros;
            }

        }


        public static List<Utilizador> Utilizadores
        {
            get
            {
                return Utilizador;
            }
        }
    }

    
    
}
