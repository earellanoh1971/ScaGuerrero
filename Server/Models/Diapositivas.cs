using System;
using System.Collections.Generic;

namespace ScaGuerrero.Server.Models
{
    public partial class Diapositivas
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdImagen { get; set; }
    }
}
