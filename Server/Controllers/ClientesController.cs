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
    public class ClientesController : Controller
    {        
        [HttpGet]
        [Route("api/Clientes/obtenerCliente/{Id}")]
        public ClientesVM ObtenerCliente(int Id)
        {
            ClientesVM oClientesVM = new();
            using ApplicationDbContext db = new();
            oClientesVM = (from cliente in db.Clientes
                           where cliente.Id== Id
                           select new ClientesVM
                           {
                               Id = cliente.Id,
                               Curp = cliente.Curp,
                               Rfc = cliente.Rfc,
                               Nombre = cliente.Nombre,
                               Calle = cliente.Calle,
                               Numero = cliente.Numero,
                               Colonia = cliente.Colonia,
                               Localidad = cliente.Localidad,
                               Ciudad = cliente.Ciudad,
                               Estado = cliente.Estado,
                               EMail = cliente.EMail,
                               Telefono = cliente.Telefono,
                               Telefono2 = cliente.Telefono2,
                               AtnCobranza = cliente.AtnCobranza,
                               AtnVentas = cliente.AtnVentas,
                               IdImagen = cliente.IdImagen,
                               Saldo = cliente.Saldo
                           }).First();

            return oClientesVM;
        }

        [HttpPost]
        [Route("api/Clientes/Guardar")]

        public bool Guardar([FromBody] ClientesVM oClientesVM)
        {
            bool respuesta = false;           
            try
            {                
                using ApplicationDbContext db = new();
                if (oClientesVM.Id == 0)
                {
                    Clientes oClientes = new();
                    oClientes.Curp = oClientesVM.Curp.ToUpper();
                    oClientes.Rfc = oClientesVM.Rfc.ToUpper();
                    oClientes.Nombre = oClientesVM.Nombre;
                    oClientes.Calle = oClientesVM.Calle;
                    oClientes.Numero = oClientesVM.Numero;
                    oClientes.Colonia = oClientesVM.Colonia;
                    oClientes.Localidad = oClientesVM.Localidad;
                    oClientes.Ciudad = oClientesVM.Ciudad;
                    oClientes.Estado = oClientesVM.Estado;
                    oClientes.EMail = oClientesVM.EMail.ToLower();
                    oClientes.Telefono = oClientesVM.Telefono;
                    oClientes.Telefono2 = oClientesVM.Telefono2;
                    oClientes.AtnCobranza = oClientesVM.AtnCobranza;
                    oClientes.AtnVentas = oClientesVM.AtnVentas;
                    oClientes.IdImagen = oClientesVM.IdImagen;
                    oClientes.Saldo = oClientesVM.Saldo;
                    db.Clientes.Add(oClientes);
                    db.SaveChanges();
                    respuesta = true;
                }
                else
                {
                    
                    Clientes oClientes = db.Clientes.Where(p => p.Id == oClientesVM.Id).First();
                    if(oClientesVM.IdImagen != oClientes.IdImagen)
                    {
                       Imagenes oImagen = db.Imagenes.Where(p => p.Id == oClientes.IdImagen).First();
                       db.Imagenes.Remove(oImagen);                       
                    }
                    oClientes.Curp = oClientesVM.Curp.ToUpper();
                    oClientes.Rfc = oClientesVM.Rfc.ToUpper();
                    oClientes.Nombre = oClientesVM.Nombre;
                    oClientes.Calle = oClientesVM.Calle;
                    oClientes.Numero = oClientesVM.Numero;
                    oClientes.Colonia = oClientesVM.Colonia;
                    oClientes.Localidad = oClientesVM.Localidad;
                    oClientes.Ciudad = oClientesVM.Ciudad;
                    oClientes.Estado = oClientesVM.Estado;
                    oClientes.EMail = oClientesVM.EMail.ToLower();
                    oClientes.Telefono = oClientesVM.Telefono;
                    oClientes.Telefono2 = oClientesVM.Telefono2;
                    oClientes.AtnCobranza = oClientesVM.AtnCobranza;
                    oClientes.AtnVentas = oClientesVM.AtnVentas;
                    oClientes.IdImagen = oClientesVM.IdImagen;
                    oClientes.Saldo = oClientesVM.Saldo;                    
                    db.SaveChanges();
                    respuesta = true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                respuesta = false;
            }
            return respuesta;
        }        


        [HttpGet]
        [Route("api/Clientes/Get")]
        public List<ClientesVM> Get()
        {
            List<ClientesVM> lista = new();
            using (ApplicationDbContext db = new())
            {
                lista = (from cliente in db.Clientes
                         select new ClientesVM
                         {
                             Id = cliente.Id,                             
                             Nombre = cliente.Nombre,
                             Telefono = cliente.Telefono,
                             EMail = cliente.EMail 
                         }
                    ).ToList();
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Clientes/Filtrar/{data?}")]
        public List<ClientesVM> Filtrar(string data)
        {
            List<ClientesVM> lista = new();
            using (ApplicationDbContext db = new())
            {
                if (data == null)
                {
                    lista = (from cliente in db.Clientes
                             select new ClientesVM
                             {
                                 Id = cliente.Id,                                 
                                 Nombre = cliente.Nombre,
                                 Telefono = cliente.Telefono,
                                 EMail = cliente.EMail
                             }
                        ).ToList();
                }
                else
                {
                    lista = (from Clientes in db.Clientes
                             where Clientes.Nombre.ToUpper().Contains(data.ToUpper()) || Clientes.Telefono.ToUpper().Contains(data.ToUpper())
                             select new ClientesVM
                             {
                                 Id = Clientes.Id,                                 
                                 Nombre = Clientes.Nombre,
                                 Telefono = Clientes.Telefono,
                                 EMail = Clientes.EMail
                             }
                        ).ToList();
                }
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Clientes/Eliminar/{data?}")]
        public int EliminarClientes(string data)
        {

            int resultado = 0;
            try
            {
                using ApplicationDbContext db = new();
                int idCliente = int.Parse(data);
                
                Clientes oCliente = db.Clientes.Where(p => p.Id == idCliente).First();
                Imagenes oImagen = db.Imagenes.Where(p => p.Id == oCliente.IdImagen).First();
                db.Clientes.Remove(oCliente);
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
        [Route("api/Clientes/Buscar/{data?}")]
        public ClientesVM Buscar(string data)
        {
            int idCliente = int.Parse(data);
            using ApplicationDbContext db = new();

            Clientes oCliente = db.Clientes.Where(p => p.Id == idCliente).First();

            ClientesVM cliente = new();
            cliente.Id = oCliente.Id;
            cliente.Curp = oCliente.Curp;
            cliente.Rfc = oCliente.Rfc;
            cliente.Nombre = oCliente.Nombre;
            cliente.Calle = oCliente.Calle;
            cliente.Numero = oCliente.Numero;
            cliente.Colonia = oCliente.Colonia;
            cliente.Localidad = oCliente.Localidad;
            cliente.Ciudad = oCliente.Ciudad;
            cliente.Estado = oCliente.Estado;
            cliente.EMail = oCliente.EMail;
            cliente.Telefono = oCliente.Telefono;
            cliente.Telefono2 = oCliente.Telefono2;
            cliente.AtnCobranza = oCliente.AtnCobranza;
            cliente.AtnVentas = oCliente.AtnVentas;
            cliente.IdImagen = oCliente.IdImagen;
            cliente.Saldo = oCliente.Saldo;
            return cliente;
        }
    }
}