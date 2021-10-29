using System;
using System.Collections.Generic;

namespace ScaGuerrero.Server.Models
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int IdImagen { get; set; }
        public string Perfil { get; set; }
        public string Password { get; set; }
    }
}
