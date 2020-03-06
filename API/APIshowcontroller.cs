using Microsoft.AspNetCore.Mvc;
using CasaShow.Models;
using CasaShow.Data;
using System.Linq;
using System;

namespace Projeto_Casa_master.API 
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class APIshowcontroller : ControllerBase
    {

        private readonly ApplicationsDbContext database;
        private readonly object sTemp;

        public APIshowcontroller (ApplicationsDbContext database){
            this.database = database;
        }


        [HttpGet]
        public IActionResult Get() {
              var shows  = database.Shows.ToList();
                return Ok (shows); //Statys Code = 200 && dados
        }


        [HttpGet("{Id}")]
        public IActionResult Get(int Id) {
            try{
                Show show  = database.Shows.First(s => s.Id == Id);
                return Ok (show);
    
            }catch (Exception ) {
                Response.StatusCode = 404;
                return new ObjectResult (new{msg = "Id inválido"});

            }
        }

        [HttpPost]
        public IActionResult Post ([FromBody] Show sTemp){

            /*Validação*/

            if(sTemp.Valor <= 0){
                Response.StatusCode = 400;
                return new ObjectResult (new {msg = "O preço do evento não pode ser menor ou igual à 0"});
            }

            if(sTemp.Nome.Length <= 1){
                Response.StatusCode = 400;
                return new ObjectResult (new {msg= "O nome do evento precisa ter mais de um caracter"});

            }

            Show s = new Show ();
            s.Nome = sTemp.Nome;
            s.Valor = sTemp.Valor;
            s.Hora = sTemp.Hora;
            s.Categoria = sTemp.Categoria;
            s.CasaseClubes = sTemp.CasaseClubes;
            database.Shows.Add (s);
            database.SaveChanges ();


            Response.StatusCode = 201;
            return new ObjectResult (new {msg = " Evento cadastrado com sucesso!"});
        }    

        [HttpDelete("{Id}")]
        public IActionResult Delete (int Id){
             try{
               Show show  = database.Shows.First(s => s.Id == Id);
               database.Shows.Remove (show);
               database.SaveChanges();
               return Ok ();
    
            }catch (Exception ) {
                Response.StatusCode = 404;
                return new ObjectResult (new{msg = "Id inválido"});

            }

        }

        [HttpPatch]
        public IActionResult Patch([FromBody] Show show){
            if (show.Id > 0) {

                try{ 
                var s = database.Shows.First(pTemp => pTemp.Id == show.Id);
                
                if(s != null){

                    //editar
                s.Nome = show.Nome != null ? show.Nome : s.Nome;
                s.Valor = show.Valor != 0 ? show.Valor : s.Valor;
                s.Categoria = show.Categoria != null ? show.Categoria : s.Categoria;
                s.CasaseClubes = show.CasaseClubes != null ? show.CasaseClubes : s.CasaseClubes;
                    database.SaveChanges ();
                    return Ok ();

                }
                else{
                Response.StatusCode = 404;
                return new ObjectResult (new{msg = "Evento não encontrado"});
                }

                }catch {
                Response.StatusCode = 400;
                return new ObjectResult (new{msg = "Evento não encontrado"});
                }


            }else{
                Response.StatusCode = 400;
                return new ObjectResult (new{msg = "Id do evento"});
            }
        }

    }
}