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
    public class VentasController : Controller
    {
        [HttpGet]
        [Route("/api/Ventas/Get")]
        public List<VentasVM> Get()
        {
            List<VentasVM> listaVenta = new();
            using (var db = new ApplicationDbContext() ){
                listaVenta = (from venta in db.Ventas
                              join cliente in db.Clientes on venta.IdCliente equals cliente.Id
                              join ciclo in db.Ciclos on venta.IdCiclo equals ciclo.Id
                              join usuario in db.Usuarios on venta.IdUsuario equals usuario.Id
                              select new VentasVM
                              {
                                  Id = venta.Id,
                                  Folio = venta.Folio,
                                  Fecha = venta.FechaElaboracion == null ? "" : venta.FechaElaboracion.Value.ToShortDateString(),
                                  FechaTimbrado = venta.FechaTimbrado == null ? "" : venta.FechaTimbrado.Value.ToShortDateString(),
                                  Status = venta.Status,
                                  IdCliente = venta.IdCliente == null ? "0" : venta.IdCliente.Value.ToString(),
                                  IdCiclo = venta.IdCiclo == null ? "0": venta.IdCiclo.Value.ToString(),
                                  FechaVencimiento = venta.FechaVencimiento == null ? "" : venta.FechaVencimiento.Value.ToShortDateString(),
                                  FormaPago = venta.FormaPago,
                                  MetodoPago = venta.MetodoPago,
                                  UsoCfdi = venta.UsoCfdi,
                                  Uuid = venta.Uuid,
                                  Observaciones = venta.Observaciones,
                                  Anticipo = venta.Anticipo,
                                  Descuento = venta.Descuento,
                                  SubTotal = venta.SubTotal,
                                  Iva = venta.Iva,
                                  Total = Utilerias.NumeroToPesos(venta.Total.ToString()),
                                  Timbrado = venta.Timbrado,
                                  IdUsuario = venta.IdUsuario==null ? "0":venta.IdUsuario.Value.ToString(),
                                  Cliente = cliente.Nombre,
                                  Ciclo = ciclo.Nombre,
                                  Usuario = usuario.Nombre
                              }).ToList();
            }
            return listaVenta;
        }

        [HttpGet]
        [Route("/api/Ventas/ListarClientes")]
        public List<ClientesVM> ListarClientes()
        {
            List<ClientesVM> listaClientes = new();

            using (ApplicationDbContext db = new())
            {
                listaClientes = (from cliente in db.Clientes
                                 select new ClientesVM { 
                                        Id = cliente.Id,
                                        Nombre = cliente.Nombre
                                 }).ToList();
            }
            return listaClientes;
        }

        [HttpGet]
        [Route("/api/Ventas/ListarCiclos")]
        public List<CiclosVM> ListarCiclos()
        {
            List<CiclosVM> listaCiclos = new();

            using (ApplicationDbContext db = new())
            {
                listaCiclos = (from ciclo in db.Ciclos
                                 select new CiclosVM
                                 {
                                     Id = ciclo.Id,
                                     Nombre = ciclo.Nombre
                                 }).ToList();
            }
            return listaCiclos;
        }

        [HttpGet]
        [Route("/api/Ventas/ListarUsuarios")]
        public List<UsuariosVM> ListarUsuarios()
        {
            List<UsuariosVM> listaUsuarios = new();

            using (ApplicationDbContext db = new())
            {
                listaUsuarios = (from Usuario in db.Usuarios
                               select new UsuariosVM
                               {
                                   Id = Usuario.Id,
                                   Nombre = Usuario.Nombre
                               }).ToList();
            }
            return listaUsuarios;
        }

        [HttpGet]
        [Route("/api/Ventas/ListarArticulos")]
        public List<ArticulosVM> ListarArticulos()
        {
            List<ArticulosVM> listaArticulos = new();

            using (ApplicationDbContext db = new())
            {
                listaArticulos = (from Articulo in db.Articulos
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
                                 }).ToList();
            }
            return listaArticulos;
        }

    }
}
