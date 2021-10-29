using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ScaGuerrero.Server.Models;
using ScaGuerrero.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace ScaGuerrero.Server.Controllers
{  
    [ApiController]
    public class ImagenesController : Controller
    {
        private readonly IWebHostEnvironment env;
        public ImagenesController( IWebHostEnvironment _env)
        {
            env = _env;

        }

        [HttpGet]
        [Route("api/Imagenes/Mostrar/{Id}")]
        public IActionResult Mostrar(int Id)
        {
            string rootDir = env.ContentRootPath;


            using ApplicationDbContext db = new();                                    
            var img = db.Imagenes.Find(Id);

            if (img != null)
            {
                return File(img.BlobImagen, "image/jpeg");
            }
            else
            {
                var image = System.IO.File.OpenRead(rootDir+"/imagenes/SinImagen.jpg");
                return File(image, "image/jpeg");
            }
        }

        [HttpPost]
        [Route("api/Imagenes/Guardar")]

        public int Guardar([FromBody] ImagenesVM oImagenesVM)
        {
            int respuesta = 0;
            try
            {
                using ApplicationDbContext db = new();
                if (oImagenesVM.Id == 0)
                {
                    Imagenes oImagenes = new();
                    oImagenes.BlobImagen = oImagenesVM.BlobImagen;                   
                    db.Imagenes.Add(oImagenes);
                    db.SaveChanges();
                    respuesta = oImagenes.Id;
                    

                }
                else
                {
                    Imagenes oImagenes = db.Imagenes.Where(p => p.Id == oImagenesVM.Id).First();
                    oImagenes.BlobImagen = oImagenesVM.BlobImagen;                    
                    db.SaveChanges();
                    respuesta = oImagenes.Id;

                }
            }
            catch (Exception e)
            {                
                Console.WriteLine(e.Message);
                respuesta = 0;
            }
            return respuesta;
        }
    }
}
