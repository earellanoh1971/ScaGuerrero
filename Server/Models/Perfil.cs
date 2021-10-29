using System;
using System.Collections.Generic;

namespace ScaGuerrero.Server.Models
{
    public partial class Perfil
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }
    }
}
