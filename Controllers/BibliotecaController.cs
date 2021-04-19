using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2__aplicação.Controllers
{
    public class BibliotecaController : Controller
    {
        public IActionResult PrimeiraPaginaJogo()
        {
            return View();
        }

      
    }
}
