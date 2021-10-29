using System;
using System.Collections.Generic;

namespace ScaGuerrero.Server.Models
{
    public partial class Articulos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public bool Producto { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Almacen { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal Precio2 { get; set; }
        public decimal PrecioCredito { get; set; }
        public decimal Iva { get; set; }
        public decimal Costo { get; set; }
        public decimal Existencia { get; set; }
        public decimal StockMinimo { get; set; }
        public string UltimaCompra { get; set; }
        public string UltimaVenta { get; set; }
        public int IdImagen { get; set; }
        public string UnidadSat { get; set; }
        public string CveSat { get; set; }
    }
}
