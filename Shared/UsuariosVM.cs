using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaGuerrero.Shared
{
    public class UsuariosVM
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        [Required(ErrorMessage="Debe ingresar la direccion de correo electrónico")]
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int IdImagen { get; set; }
        public string Perfil { get; set; }
        [Required(ErrorMessage = "Debe ingresar la contraseña")]
        public string Password { get; set; }
    }
}
