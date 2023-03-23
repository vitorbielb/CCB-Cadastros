using Microsoft.AspNetCore.Mvc;
using CCB_Cadastros.Data;
using CCB_Cadastros.Models;
using CCB_Cadastros.Models;

namespace CCB_Cadastros.Controllers
{
    public class IgrejasController : Controller
    {
        private readonly ApplicationDbContext _db;

        public IgrejasController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Cadastros);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Igreja igreja)
        {
            _db.Cadastros.Add(igreja);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var igreja = _db.Cadastros.FirstOrDefault(x => x.Id == id);
            return View(igreja);
        }
        [HttpPost]
        public IActionResult Update(Igreja igreja)
        {
            _db.Cadastros.Update(igreja);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var igreja = _db.Cadastros.FirstOrDefault(x => x.Id == id);
            return View(igreja);
        }
        [HttpPost]
        public IActionResult Delete(Igreja igreja)
        {
            _db.Cadastros.Remove(igreja);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
