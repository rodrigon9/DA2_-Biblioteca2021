using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2__aplicação.Models
{
    public static class Repositorio
    {
        private static List<Livro> repositorioLivros = new List<Livro>();

        public static List<Livro> RepositorioDeLivros
        {
            get
            {
                return repositorioLivros;
            }

        }
    }

    
    
}
