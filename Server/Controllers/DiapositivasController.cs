using Microsoft.AspNetCore.Mvc;
using System;
using ScaGuerrero.Shared;
using ScaGuerrero.Server.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace ScaGuerrero.Server.Controllers
{
    [ApiController]
    public class DiapositivasController : Controller
    {
        [HttpGet]
        [Route("api/Diapositivas/obtenerDiapositiva/{Id}")]
        public DiapositivasVM ObtenerDiapositiva(int Id)
        {
            DiapositivasVM oDiapositivasVM = new();
            using ApplicationDbContext db = new();
            oDiapositivasVM = (from diapositiva in db.Diapositivas
                           where diapositiva.Id == Id
                           select new DiapositivasVM
                           {
                               Id = diapositiva.Id,
                               Descripcion = diapositiva.Descripcion,                               
                               IdImagen = diapositiva.IdImagen
                               
                           }).First();

            return oDiapositivasVM;
        }

        [HttpPost]
        [Route("api/Diapositivas/Guardar")]

        public bool Guardar([FromBody] DiapositivasVM oDiapositivasVM)
        {
            bool respuesta = false;
            try
            {
                using ApplicationDbContext db = new();
                if (oDiapositivasVM.Id == 0)
                {
                    Diapositivas oDiapositivas = new();
                    
                    oDiapositivas.Descripcion = oDiapositivasVM.Descripcion;
                    oDiapositivas.IdImagen = oDiapositivasVM.IdImagen;                  
                    db.Diapositivas.Add(oDiapositivas);
                    db.SaveChanges();
                    respuesta = true;
                }
                else
                {

                    Diapositivas oDiapositivas = db.Diapositivas.Where(p => p.Id == oDiapositivasVM.Id).First();
                    if (oDiapositivasVM.IdImagen != oDiapositivas.IdImagen)
                    {
                        Imagenes oImagen = db.Imagenes.Where(p => p.Id == oDiapositivas.IdImagen).First();
                        db.Imagenes.Remove(oImagen);
                    }
                    oDiapositivas.Descripcion = oDiapositivasVM.Descripcion;
                    oDiapositivas.IdImagen = oDiapositivasVM.IdImagen;
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
        [Route("api/Diapositivas/Get")]
        public List<DiapositivasVM> Get()
        {
            List<DiapositivasVM> lista = new();
            using (ApplicationDbContext db = new())
            {
                lista = (from diapositiva in db.Diapositivas
                         select new DiapositivasVM
                         {
                             Id = diapositiva.Id,
                             Descripcion = diapositiva.Descripcion,
                             IdImagen = diapositiva.IdImagen
                         }
                    ).ToList();
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Diapositivas/Filtrar/{data?}")]
        public List<DiapositivasVM> Filtrar(string data)
        {
            List<DiapositivasVM> lista = new();
            using (ApplicationDbContext db = new())
            {
                if (data == null)
                {
                    lista = (from diapositiva in db.Diapositivas
                             select new DiapositivasVM
                             {
                                 Id = diapositiva.Id,
                                 Descripcion = diapositiva.Descripcion,
                                 IdImagen = diapositiva.IdImagen
                             }
                        ).ToList();
                }
                else
                {
                    lista = (from diapositiva in db.Diapositivas
                             where diapositiva.Descripcion.ToUpper().Contains(data.ToUpper())
                             select new DiapositivasVM
                             {
                                 Id = diapositiva.Id,
                                 Descripcion = diapositiva.Descripcion,
                                 IdImagen = diapositiva.IdImagen
                             }
                        ).ToList();
                }
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Diapositivas/Eliminar/{data?}")]
        public int EliminarDiapositivas(string data)
        {

            int resultado = 0;
            try
            {
                using ApplicationDbContext db = new();
                int idDiapositiva = int.Parse(data);

                Diapositivas oDiapositiva = db.Diapositivas.Where(p => p.Id == idDiapositiva).First();
                Imagenes oImagen = db.Imagenes.Where(p => p.Id == oDiapositiva.IdImagen).First();
                db.Diapositivas.Remove(oDiapositiva);
                db.Imagenes.Remove(oImagen);
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
        [Route("api/Diapositivas/Buscar/{data?}")]
        public DiapositivasVM Buscar(string data)
        {
            int idDiapositiva = int.Parse(data);
            using ApplicationDbContext db = new();

            Diapositivas oDiapositiva = db.Diapositivas.Where(p => p.Id == idDiapositiva).First();

            DiapositivasVM diapositiva = new();
            diapositiva.Id = oDiapositiva.Id;
            diapositiva.Descripcion = oDiapositiva.Descripcion;           
            diapositiva.IdImagen = oDiapositiva.IdImagen;            
            return diapositiva;
        }
    }
}