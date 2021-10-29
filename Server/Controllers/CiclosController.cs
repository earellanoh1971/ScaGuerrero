using Microsoft.AspNetCore.Mvc;
using ScaGuerrero.Server.Models;
using ScaGuerrero.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScaGuerrero.Server.Controllers
{
    [ApiController]
    public class CiclosController : Controller
    {
        [HttpGet]
        [Route("api/Ciclos/obtenerCiclo/{Id}")]
        public CiclosVM ObtenerCiclo(int Id)
        {
            CiclosVM oCiclosVM = new();
            using ApplicationDbContext db = new();
            oCiclosVM = (from Ciclo in db.Ciclos
                           where Ciclo.Id == Id
                           select new CiclosVM
                           {
                               Id = Ciclo.Id,                               
                               Nombre = Ciclo.Nombre                              
                           }).First();

            return oCiclosVM;
        }

        [HttpPost]
        [Route("api/Ciclos/Guardar")]

        public bool Guardar([FromBody] CiclosVM oCiclosVM)
        {
            bool respuesta = false;
            try
            {
                using ApplicationDbContext db = new();
                if (oCiclosVM.Id == 0)
                {
                    Ciclos oCiclos = new();                   
                    oCiclos.Nombre = oCiclosVM.Nombre.ToUpper();                   
                    db.Ciclos.Add(oCiclos);
                    db.SaveChanges();
                    respuesta = true;
                }
                else
                {

                    Ciclos oCiclos = db.Ciclos.Where(p => p.Id == oCiclosVM.Id).First();                    
                    oCiclos.Nombre = oCiclosVM.Nombre.ToUpper();                    
                    db.SaveChanges();
                    respuesta = true;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                respuesta = false;
            }
            return respuesta;
        }


        [HttpGet]
        [Route("api/Ciclos/Get")]
        public List<CiclosVM> Get()
        {
            List<CiclosVM> lista = new();
            using (ApplicationDbContext db = new())
            {
                lista = (from Ciclo in db.Ciclos
                         select new CiclosVM
                         {
                             Id = Ciclo.Id,
                             Nombre = Ciclo.Nombre                          
                         }
                    ).ToList();
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Ciclos/Filtrar/{data?}")]
        public List<CiclosVM> Filtrar(string data)
        {
            List<CiclosVM> lista = new();
            using (ApplicationDbContext db = new())
            {
                if (data == null)
                {
                    lista = (from Ciclo in db.Ciclos
                             select new CiclosVM
                             {
                                 Id = Ciclo.Id,
                                 Nombre = Ciclo.Nombre
                                
                             }
                        ).ToList();
                }
                else
                {
                    lista = (from Ciclos in db.Ciclos
                             where Ciclos.Nombre.Contains(data)
                             select new CiclosVM
                             {
                                 Id = Ciclos.Id,
                                 Nombre = Ciclos.Nombre
                             }
                        ).ToList();
                }
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Ciclos/Eliminar/{data?}")]
        public int EliminarCiclos(string data)
        {

            int resultado = 0;
            try
            {
                using ApplicationDbContext db = new();
                int idCiclo = int.Parse(data);
                Ciclos oCiclo = db.Ciclos.Where(p => p.Id == idCiclo).First();
                db.Ciclos.Remove(oCiclo);
                db.SaveChanges();
                resultado = 1;
            }
            catch (Exception ex)
            {
                var Mensaje = ex.Message;
                resultado = 0;
            }

            return resultado;
        }

        [HttpGet]
        [Route("api/Ciclos/Buscar/{data?}")]
        public CiclosVM Buscar(string data)
        {
            int idCiclo = int.Parse(data);
            using ApplicationDbContext db = new();
            Ciclos oCiclo = db.Ciclos.Where(p => p.Id == idCiclo).First();
            CiclosVM Ciclo = new();
            Ciclo.Id = oCiclo.Id;           
            Ciclo.Nombre = oCiclo.Nombre;            
            return Ciclo;
        }
    }
}
