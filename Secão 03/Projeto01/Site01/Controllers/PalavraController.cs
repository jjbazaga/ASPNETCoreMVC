using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Models;

namespace Site01.Controllers
{
    public class PalavraController : Controller
    {
        private DatabaseContext _db;
        public PalavraController(DatabaseContext db)
        {
            _db = db;
        }

        //Listar todas as palavras do banco de dados
        public IActionResult Index()
        {
            ViewBag.Palavras=_db.Palavras.ToList();
            return View();
        }

        //CRUD (Create, Read, Update, Delete): Criar, Ler(Editar), Atualizar, Excluir(Apagar)
        //Vamos lá
        //Criar
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar([FromForm]Palavra palavra)
        {
            return View();
        }

        //Atualizar
        [HttpGet]
        public IActionResult Atualizar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar([FromForm]Palavra palavra)
        {
            return View();
        }

        //Ecluir
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            //TODO - Excluir registros no banco de dados
            return RedirectToAction("Index");
        }
    }
}