using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReadyToEat.Models;
namespace ReadyToEat.Controllers
{
    public class RestaurantesController:Controller
    {
        private readonly ReadyToEatContext _context;
        public RestaurantesController(ReadyToEatContext context){
            this._context=context;
        }
        public IActionResult LoginRestaurantes()
        {
            return View();
        }
        
        
        public IActionResult RegistroRestaurante()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult LoginRestaurantes(Login log)
        {
            if(ModelState.IsValid){

                return RedirectToAction("PrincipalDeRestaurantes","Confirmaciones");
            }
            return View("LoginRestaurantes",log);
        }
        
       [HttpPost] 
        public IActionResult RegistroRestaurante(RegistroRest res)
        {
            if(ModelState.IsValid){
                _context.Add(res);
                _context.SaveChanges();
                return RedirectToAction("PrincipalDeRestaurantes","Confirmaciones");
            }
            return View("RegistroRestaurante",res);
        }
    }
}