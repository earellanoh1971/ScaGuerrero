using System;
using System.Collections.Generic;

namespace ScaGuerrero.Server.Models
{
    public partial class Partidas
    {
        public int Id { get; set; }
        public int? Usuario { get; set; }
        public int? IdArticulo { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Iva { get; set; }
        public decimal? Importe { get; set; }
    }
}
