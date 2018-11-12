using Microsoft.AspNetCore.Mvc;
using ReadyToEat.Models;

namespace ReadyToEat.Controllers
{
    public class ConfirmacionesController: Controller
    {
        private readonly ReadyToEatContext _contex;
        public ConfirmacionesController(ReadyToEatContext context){

            this._contex=context;
        }
        public IActionResult PrincipalDeRestaurantes()
        {
            return View();
        }
        

        public IActionResult RegistroMenu(Menu menu)
        { 
            if(ModelState.IsValid){
            _contex.Add(menu);
            _contex.SaveChanges();
            return RedirectToAction("conRegMenu","Confirmaciones");

            }
            return View("RegistroMenu",menu);
        }
        public IActionResult conRegMenu()
        {
            return View();
        }
        
    }
}
