using asp.net2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace asp.net2.Controllers
{
    public class EscuelaController:Controller
    {
         public IActionResult Escuelaindex(){

         var escuela=new Escuela();
         escuela.añoFundacion=2025;
         escuela.Nombre="Escuela ingenieria";
         escuela.EscuelaId = Guid.NewGuid().ToString();
    
            return View(escuela);
    
         }
    }
}