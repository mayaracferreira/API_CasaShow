using Microsoft.AspNetCore.Mvc;
using CasaShow.Models;
using CasaShow.Data;
using System.Linq;
using System;

namespace Projeto_Casa_master.API
{
[Route("api/v1/[controller]")]
    [ApiController]
    public class APIcasascontroller : ControllerBase
    {

        private readonly ApplicationsDbContext database;

        public APIcasascontroller (ApplicationsDbContext database){
            this.database = database;
        }


        [HttpGet]
        public IActionResult Get() {
              var casas  = database.Casas.ToList();
                return Ok (casas); //Statys Code = 200 && dados
        }


        [HttpGet("{Id}")]
        public IActionResult Get(int Id) {
            try{
                Casa casa  = database.Casas.First(c => c.Id == Id);
                return Ok (casa);
    
            }catch (Exception ) {
                Response.StatusCode = 404;
                return new ObjectResult (new{msg = "Id inválido"});

            }
        }

        [HttpPost]
        public IActionResult Post ([FromBody] Casa cTemp){

            /*Validação*/

                if(cTemp.Nome.Length <= 1){
                Response.StatusCode = 400;
                return new ObjectResult (new {msg= "O nome da Casa/Clube precisa ter mais de um caracter"});

            }

            Casa c = new Casa ();
            c.Nome = cTemp.Nome;
            c.Endereço = cTemp.Endereço;
            database.Casas.Add (c);
            database.SaveChanges ();


            Response.StatusCode = 201;
            return new ObjectResult (new {msg = " Casa/Clube cadastrada (o) com sucesso!"});
        }    

        [HttpDelete("{Id}")]
        public IActionResult Delete (int Id){
             try{
               Casa casa  = database.Casas.First(c => c.Id == Id);
               database.Casas.Remove (casa);
               database.SaveChanges();
               return Ok ();
    
            }catch (Exception ) {
                Response.StatusCode = 404;
                return new ObjectResult (new{msg = "Id inválido"});

            }

        }

        [HttpPatch]
         public IActionResult Patch([FromBody] Casa casa){
            if (casa.Id > 0) {

                try{ 
                var c = database.Casas.First(cTemp => cTemp.Id == casa.Id);
                
                if(c != null){

                    //editar
                c.Nome = casa.Nome != null ? casa.Nome : c.Nome;
                c.Endereço = casa.Endereço !=  null ? casa.Endereço : c.Endereço;
                    database.SaveChanges ();
                    return Ok ();

                }
                else{
                Response.StatusCode = 404;
                return new ObjectResult (new{msg = "Casa/Clube não encontrado"});
                }

                }catch {
                Response.StatusCode = 400;
                return new ObjectResult (new{msg = "Casa/Clube não encontrado"});
                }


            }else{
                Response.StatusCode = 400;
                return new ObjectResult (new{msg = "Id da Casa/Clube invalido"});
            }

         }    
    }
}