using System;
using System.Collections.Generic;

namespace ScaGuerrero.Server.Models
{
    public partial class Imagenes
    {
        public int Id { get; set; }
        public byte[] BlobImagen { get; set; }
    }
}
