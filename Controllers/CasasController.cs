using System;
using Microsoft.AspNetCore.Mvc;
using CasaShow.Controllers;
using CasaShow.Data;
using CasaShow.Models;
using System.Linq;

namespace CasaShow.Controllers
{
    public class CasasController : Controller
    {

         private readonly ApplicationsDbContext database;

        public CasasController (ApplicationsDbContext database) {
                this.database = database;
        }

        public IActionResult CadastrarCasas (){
            return View ();
        }

        public IActionResult Editar (int Id){
           return RedirectToAction ("CadastrarCasas");
       }

       
       public IActionResult Deletar (int ID){
            Casa aux = database.Casas.First (aux => aux.Id == ID);
          database.Casas.Remove(aux);
          database.SaveChanges();
           return RedirectToAction ("CasaseClubes"); 
       }

        [HttpPost]
       public IActionResult Salvar (Casa casa){
            if(casa.Nome != null && casa.Endereço != null){
           database.Casas.Add(casa);  
           database.SaveChanges();
           return RedirectToAction ("CasaseClubes");
       }
       else {
            Response.StatusCode = 400;
            return new ObjectResult (new {msg= "O nome e o endereço da Casa/Clube precisam ser preenchidos"});
       }

       
       
           
       }


        public IActionResult CasaseClubes()  {

           ViewBag.CasaseClubes = database.Casas.ToList();

            return View();
        }



       }






       
      /* public IActionResult Deletar (int ID){
            Show aux = database.Shows.First (aux => aux.Id == ID);
          database.Shows.Remove(aux);
          database.SaveChanges();
           return RedirectToAction ("Proximos"); */
    }
