using DevIO.IU.Web.Data;
using DevIO.IU.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.IU.Web.Controllers
{
    public class TestCrudController : Controller
    {
        private readonly MeuDbContext _contexto;

        public TestCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno() { 
                Nome = "Rafael",
                DataNascimento = DateTime.Now,
                Email = "rafacout@gmail.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);

            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == "rafacout@gmail.com");

            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "Eduardo");

            aluno.Nome = "João";

            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }
}
