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
    public class ArticulosController : Controller
    {
        [HttpGet]
        [Route("api/Articulos/obtenerArticulo/{Id}")]
        public ArticulosVM ObtenerArticulo(int Id)
        {
            ArticulosVM oArticulosVM = new();
            using ApplicationDbContext db = new();
            oArticulosVM = (from Articulo in db.Articulos
                            where Articulo.Id == Id
                            select new ArticulosVM
                            {
                                Id = Articulo.Id,
                                Codigo = Articulo.Codigo,
                                Producto = Articulo.Producto,
                                Descripcion = Articulo.Descripcion,
                                Unidad = Articulo.Unidad,
                                Marca = Articulo.Marca,
                                Linea = Articulo.Linea,
                                Almacen = Articulo.Almacen,
                                PrecioPublico = Articulo.PrecioPublico,
                                CPrecioPublico = Utilerias.NumeroToPesos(Articulo.PrecioPublico.ToString()),
                                Precio2 = Articulo.Precio2,
                                PrecioCredito = Articulo.PrecioCredito,
                                Iva = Articulo.Iva,
                                Costo = Articulo.Costo,
                                Existencia = Articulo.Existencia,
                                CExistencia = Utilerias.NumeroToPesos(Articulo.Existencia.ToString()),                                
                                StockMinimo = Articulo.StockMinimo,
                                UltimaCompra = Articulo.UltimaCompra,
                                UltimaVenta = Articulo.UltimaVenta,
                                IdImagen = Articulo.IdImagen,
                                CveSat = Articulo.CveSat
                            }).First();

            return oArticulosVM;
        }

        [HttpPost]
        [Route("api/Articulos/Guardar")]

        public bool Guardar([FromBody] ArticulosVM oArticulosVM)
        {
            bool respuesta = false;
            try
            {
                using ApplicationDbContext db = new();
                if (oArticulosVM.Id == 0)
                {
                    Articulos oArticulos = new();
                    oArticulos.Id = oArticulosVM.Id;
                    oArticulos.Codigo = oArticulosVM.Codigo;
                    oArticulos.Producto = oArticulosVM.Producto;
                    oArticulos.Descripcion = oArticulosVM.Descripcion;
                    oArticulos.Unidad = oArticulosVM.Unidad;
                    oArticulos.Marca = oArticulosVM.Marca;
                    oArticulos.Linea = oArticulosVM.Linea;
                    oArticulos.Almacen = oArticulosVM.Almacen;
                    oArticulos.PrecioPublico = oArticulosVM.PrecioPublico;
                    oArticulos.Precio2 = oArticulosVM.Precio2;
                    oArticulos.PrecioCredito = oArticulosVM.PrecioCredito;
                    oArticulos.Iva = oArticulosVM.Iva;
                    oArticulos.Costo = oArticulosVM.Costo;
                    oArticulos.Existencia = oArticulosVM.Existencia;
                    oArticulos.StockMinimo = oArticulosVM.StockMinimo;
                    oArticulos.UltimaCompra = oArticulosVM.UltimaCompra;
                    oArticulos.UltimaVenta = oArticulosVM.UltimaVenta;                    
                    oArticulos.IdImagen = oArticulosVM.IdImagen;
                    oArticulos.CveSat = oArticulosVM.CveSat;
                    db.Articulos.Add(oArticulos);
                    db.SaveChanges();
                    respuesta = true;
                }
                else
                {

                    Articulos oArticulos = db.Articulos.Where(p => p.Id == oArticulosVM.Id).First();
                    oArticulos.Id = oArticulosVM.Id;
                    oArticulos.Codigo = oArticulosVM.Codigo;
                    oArticulos.Producto = oArticulosVM.Producto;
                    oArticulos.Descripcion = oArticulosVM.Descripcion;
                    oArticulos.Unidad = oArticulosVM.Unidad;
                    oArticulos.Marca = oArticulosVM.Marca;
                    oArticulos.Linea = oArticulosVM.Linea;
                    oArticulos.Almacen = oArticulosVM.Almacen;
                    oArticulos.PrecioPublico = oArticulosVM.PrecioPublico;                    
                    oArticulos.Precio2 = oArticulosVM.Precio2;
                    oArticulos.PrecioCredito = oArticulosVM.PrecioCredito;
                    oArticulos.Iva = oArticulosVM.Iva;
                    oArticulos.Costo = oArticulosVM.Costo;
                    oArticulos.Existencia = oArticulosVM.Existencia;
                    oArticulos.StockMinimo = oArticulosVM.StockMinimo;
                    oArticulos.UltimaCompra = oArticulosVM.UltimaCompra;
                    oArticulos.UltimaVenta = oArticulosVM.UltimaVenta;
                    oArticulos.IdImagen = oArticulosVM.IdImagen;
                    oArticulos.CveSat = oArticulosVM.CveSat;
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
        [Route("api/Articulos/Get")]
        public List<ArticulosVM> Get()
        {
            List<ArticulosVM> lista = new();
            using (ApplicationDbContext db = new())
            {
                lista = (from Articulo in db.Articulos
                         select new ArticulosVM
                         {
                             Id = Articulo.Id,
                             Codigo = Articulo.Codigo,
                             Descripcion = Articulo.Descripcion,
                             PrecioPublico = Articulo.PrecioPublico,
                             CPrecioPublico = Utilerias.NumeroToPesos(Articulo.PrecioPublico.ToString()),
                             Existencia = Articulo.Existencia,
                             CExistencia = Utilerias.NumeroToPesos(Articulo.Existencia.ToString())
                         }
                    ).ToList();
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Articulos/Filtrar/{data?}")]
        public List<ArticulosVM> Filtrar(string data)
        {
            List<ArticulosVM> lista = new();
            using (ApplicationDbContext db = new())
            {
                if (data == null)
                {
                    lista = (from Articulo in db.Articulos
                             select new ArticulosVM
                             {
                                 Id = Articulo.Id,
                                 Codigo = Articulo.Codigo,
                                 Unidad = Articulo.Unidad,
                                 Descripcion = Articulo.Descripcion,
                                 CPrecioPublico = Utilerias.NumeroToPesos(Articulo.PrecioPublico.ToString()),
                                 PrecioPublico = Articulo.PrecioPublico,                                 
                                 Existencia = Articulo.Existencia,
                                 CExistencia = Utilerias.NumeroToPesos(Articulo.Existencia.ToString())

                             }
                        ).ToList();
                }
                else
                {
                    lista = (from Articulo in db.Articulos
                             where Articulo.Descripcion.ToUpper().Contains(data.ToUpper()) || Articulo.Codigo.ToUpper().Contains(data.ToUpper())
                             select new ArticulosVM
                             {
                                 Id = Articulo.Id,
                                 Codigo = Articulo.Codigo,
                                 Unidad = Articulo.Unidad,
                                 Descripcion = Articulo.Descripcion,
                                 CPrecioPublico = Utilerias.NumeroToPesos(Articulo.PrecioPublico.ToString()),
                                 PrecioPublico = Articulo.PrecioPublico,                                 
                                 Existencia = Articulo.Existencia,
                                 CExistencia = Utilerias.NumeroToPesos(Articulo.Existencia.ToString())                                 
                             }
                        ).ToList();
                }
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Articulos/Eliminar/{data?}")]
        public int EliminarArticulos(string data)
        {

            int resultado = 0;
            try
            {
                using ApplicationDbContext db = new();
                int idArticulo = int.Parse(data);
                Articulos oArticulo = db.Articulos.Where(p => p.Id == idArticulo).First();
                db.Articulos.Remove(oArticulo);
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
        [Route("api/Articulos/Buscar/{data?}")]
        public ArticulosVM Buscar(string data)
        {
            int idArticulo = int.Parse(data);
            using ApplicationDbContext db = new();

            Articulos articulo = db.Articulos.Where(p => p.Id == idArticulo).First();

            ArticulosVM articuloVM = new();

            articuloVM.Id = articulo.Id;
            articuloVM.Codigo = articulo.Codigo;
            articuloVM.Producto = articulo.Producto;
            articuloVM.Descripcion = articulo.Descripcion;
            articuloVM.Unidad = articulo.Unidad;
            articuloVM.Marca = articulo.Marca;
            articuloVM.Linea = articulo.Linea;
            articuloVM.Almacen = articulo.Almacen;            
            articuloVM.CPrecioPublico = Utilerias.NumeroToPesos(articulo.PrecioPublico.ToString());
            articuloVM.PrecioPublico = articulo.PrecioPublico;
            articuloVM.Precio2 = articulo.Precio2;
            articuloVM.PrecioCredito = articulo.PrecioCredito;
            articuloVM.Iva = articulo.Iva;
            articuloVM.Costo = articulo.Costo;
            articuloVM.Existencia = articulo.Existencia;
            articuloVM.CExistencia = Utilerias.NumeroToPesos(articulo.Existencia.ToString());
            articuloVM.StockMinimo = articulo.StockMinimo;
            articuloVM.UltimaCompra = articulo.UltimaCompra;
            articuloVM.UltimaVenta = articulo.UltimaVenta;
            articuloVM.IdImagen = articulo.IdImagen;
            articuloVM.CveSat = articulo.CveSat;
            return articuloVM;
        }

        [HttpGet]
        [Route("api/Articulos/BuscarCodigo/{data?}")]
        public ArticulosVM BuscarCodigo(string data)
        {
            data = data.ToUpper();
            using ApplicationDbContext db = new();

            Articulos articulo = db.Articulos.Where(p => p.Codigo.ToUpper() == data).First();

            ArticulosVM articuloVM = new();
            articuloVM.Id = articulo.Id;
            articuloVM.Codigo = articulo.Codigo;
            articuloVM.Producto = articulo.Producto;
            articuloVM.Descripcion = articulo.Descripcion;
            articuloVM.Unidad = articulo.Unidad;
            articuloVM.Marca = articulo.Marca;
            articuloVM.Linea = articulo.Linea;
            articuloVM.Almacen = articulo.Almacen;
            articuloVM.CPrecioPublico = Utilerias.NumeroToPesos(articulo.PrecioPublico.ToString());                                  
            articuloVM.PrecioPublico = articulo.PrecioPublico;
            articuloVM.Precio2 = articulo.Precio2;
            articuloVM.PrecioCredito = articulo.PrecioCredito;
            articuloVM.Iva = articulo.Iva;
            articuloVM.Costo = articulo.Costo;
            articuloVM.Existencia = articulo.Existencia;
            articuloVM.CExistencia = Utilerias.NumeroToPesos(articulo.Existencia.ToString());
            articuloVM.StockMinimo = articulo.StockMinimo;
            articuloVM.UltimaCompra = articulo.UltimaCompra;
            articuloVM.UltimaVenta = articulo.UltimaVenta;
            articuloVM.IdImagen = articulo.IdImagen;
            articuloVM.CveSat = articulo.CveSat;
            return articuloVM;
        }
    }
}
