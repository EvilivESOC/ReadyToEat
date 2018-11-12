using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ReadyToEat.Models;

namespace ReadyToEat.Controllers
{
    public class InicioController: Controller
    {
        
        private readonly ReadyToEatContext _context;
        public InicioController(ReadyToEatContext context){

            this._context=context;
        }
        public IActionResult Comentarios()
        {
            ViewBag.Registro = new SelectList(_context.Registro, "Id", "nombretienda");
            return View();
        }
        [HttpPost]
        public IActionResult Comentarios(comentario com)
        {
            if(ModelState.IsValid){
                
                _context.comentarios.Add(com);
                _context.SaveChanges();

                return RedirectToAction("Inicio");
            }
            return View();
        }
        public IActionResult Inicio()
        {
            var lista = _context.Registro.OrderByDescending(b => b.Id)
                                       .ToList();

            return View(lista);
        }
        public IActionResult Nosotros()
        {
            return View();
        }
        public IActionResult menuporrestaurante()
        {
            return View();
        }

    
        
    }
}