using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using ScaGuerrero.Server.Models;
using ScaGuerrero.Shared;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ScaGuerrero.Server.Controllers
{
    [ApiController]
    public class UsuariosController : Controller
    {
        private readonly IDataProtectionProvider dataProtection;
        private readonly IDataProtector dataProtector;

        public UsuariosController(IDataProtectionProvider _dataProtection)
        {
            dataProtection = _dataProtection;
            dataProtector = dataProtection.CreateProtector("UsuariosController");


        }

        [HttpGet]
        [Route("api/Usuarios/obtenerUsuario/{Id}")]
        public UsuariosVM ObtenerUsuario(int Id)
        {


            UsuariosVM oUsuariosVM = new();
            using ApplicationDbContext db = new();
            oUsuariosVM = (from usuario in db.Usuarios
                           where usuario.Id == Id
                           select new UsuariosVM
                           {
                               Id = usuario.Id,
                               Usuario = usuario.Usuario,
                               Nombre = usuario.Nombre,
                               Email = usuario.Email,
                               Telefono = usuario.Telefono,
                               IdImagen = usuario.IdImagen,
                               Perfil = usuario.Perfil,
                               Password = usuario.Password
                           }).First();

            return oUsuariosVM;
        }

        [HttpPost]
        [Route("api/Usuarios/Guardar")]

        public bool Guardar([FromBody] UsuariosVM oUsuario)
        {
            bool respuesta = false;
           

            try
            {
                using ApplicationDbContext db = new();
                if (oUsuario.Id == 0){
                    Usuarios usuario = new();
                    usuario.Id = oUsuario.Id;
                    usuario.Usuario = oUsuario.Usuario;
                    usuario.Nombre = oUsuario.Nombre;
                    usuario.Email = oUsuario.Email;
                    usuario.Telefono = oUsuario.Telefono;
                    usuario.IdImagen = oUsuario.IdImagen;
                    usuario.Perfil = oUsuario.Perfil;
                    usuario.Password = dataProtector.Protect(oUsuario.Password);
                    db.Usuarios.Add(usuario);
                    db.SaveChanges();
                    respuesta = true;
                }
                else {
                    Usuarios usuario = db.Usuarios.Where(p => p.Id == oUsuario.Id).First();
                    usuario.Id = oUsuario.Id;
                    usuario.Usuario = oUsuario.Usuario;
                    usuario.Nombre = oUsuario.Nombre;
                    usuario.Email = oUsuario.Email;
                    usuario.Telefono = oUsuario.Telefono;
                    usuario.IdImagen = oUsuario.IdImagen;
                    usuario.Perfil = oUsuario.Perfil;
                    //usuario.Password = dataProtector.Unprotect(oUsuario.Password);
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

        [HttpPost]
        [Route("api/Usuarios/Login")]
        public int Login([FromBody] UsuariosVM Usuario)
        {
            int respuesta = 0;
            int nRegs = 0;
            try
            {
                using ApplicationDbContext db = new();

                nRegs = db.Usuarios.Where(p => p.Email == Usuario.Email).Count();
                if (nRegs>0)
                {
                    Usuarios usuario = db.Usuarios.Where(p => p.Email == Usuario.Email).First();
                    string Pass = dataProtector.Unprotect(usuario.Password);
                    if (Usuario.Password == Pass)
                    {
                        respuesta = usuario.Id;
                    }
                }           
            }
            catch (Exception ex)
            {
                var Mensaje = ex.Message;
                Console.WriteLine(Mensaje);
            }            
            return respuesta;
        }

        [HttpGet]
        [Route("api/Usuarios/Get")]
        public List<UsuariosVM> Get()
        {
            List<UsuariosVM> lista = new();
            using (ApplicationDbContext db = new())
            {
                lista = (from usuario in db.Usuarios
                         select new UsuariosVM
                         {
                             Id = usuario.Id,
                             Usuario = usuario.Usuario,
                             Nombre = usuario.Nombre,
                             Email = usuario.Email,
                             Telefono = usuario.Telefono,
                             IdImagen = usuario.IdImagen,
                             Perfil = usuario.Perfil,
                             Password = usuario.Password
                         }
                    ).ToList();
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Usuarios/Filtrar/{data?}")]
        public List<UsuariosVM> Filtrar(string data)
        {
            List<UsuariosVM> lista = new();
            using (ApplicationDbContext db = new())
            {
                if (data == null)
                {
                    lista = (from usuario in db.Usuarios
                             select new UsuariosVM
                             {
                                 Id = usuario.Id,
                                 Usuario = usuario.Usuario,
                                 Nombre = usuario.Nombre,
                                 Email = usuario.Email,
                                 Telefono = usuario.Telefono,
                                 IdImagen = usuario.IdImagen,
                                 Perfil = usuario.Perfil,
                                 Password = usuario.Password
                             }
                        ).ToList();
                }
                else
                {
                    lista = (from usuario in db.Usuarios
                             where usuario.Nombre.ToUpper().Contains(data.ToUpper())
                             select new UsuariosVM
                             {
                                 Id = usuario.Id,
                                 Usuario = usuario.Usuario,
                                 Nombre = usuario.Nombre,
                                 Email = usuario.Email,
                                 Telefono = usuario.Telefono,
                                 IdImagen = usuario.IdImagen,
                                 Perfil = usuario.Perfil,
                                 Password = usuario.Password
                             }
                        ).ToList();
                }
            }
            return lista;
        }

        [HttpGet]
        [Route("api/Usuarios/Eliminar/{data?}")]
        public int EliminarUsuarios(string data)
        {

            int resultado = 0;
            try
            {
                using ApplicationDbContext db = new();
                int idUsuario = int.Parse(data);
                Usuarios oUsuario = db.Usuarios.Where(p => p.Id == idUsuario).First();
                db.Usuarios.Remove(oUsuario);
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
        [Route("api/Usuarios/Buscar/{data?}")]
        public UsuariosVM Buscar(string data)
        {
            int idUsuario = int.Parse(data);
            using ApplicationDbContext db = new();

            Usuarios oUsuario = db.Usuarios.Where(p => p.Id == idUsuario).First();

            UsuariosVM usuario = new();

            usuario.Id = oUsuario.Id;
            usuario.Usuario = oUsuario.Usuario;
            usuario.Nombre = oUsuario.Nombre;
            usuario.Email = oUsuario.Email;
            usuario.Telefono = oUsuario.Telefono;
            usuario.IdImagen = oUsuario.IdImagen;
            usuario.Perfil = oUsuario.Perfil;
            usuario.Password = oUsuario.Password;
            return usuario;
        }
    }
}
