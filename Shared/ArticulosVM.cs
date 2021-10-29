using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaGuerrero.Shared
{
    public class ArticulosVM
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "Código")]
        public string Codigo { get; set; }     
        public bool Producto { get; set; }
        public string Descripcion { get; set; }
        public string Unidad { get; set; }
        public string Marca { get; set; }
        [Display(Name = "Línea")]
        public string Linea { get; set; }
        [Display(Name = "Almacén")]
        public string Almacen { get; set; }
        public decimal PrecioPublico { get; set; }

        [Display(Name = "Precio Público")]
        public string CPrecioPublico { get; set; }
        [Display(Name = "Precio de Lista 2")]
        public decimal Precio2 { get; set; }
        [Display(Name = "Precio a Credito")]
        public decimal PrecioCredito { get; set; }
        [Display(Name = "IVA")]
        public decimal Iva { get; set; }
        [Display(Name = "Precio de Costo")]
        public decimal Costo { get; set; }
        public string CExistencia { get; set; }
        public decimal Existencia { get; set; }
        [Display(Name = "Existencias Mínimas")]
        public decimal StockMinimo { get; set; }
        [Display(Name = "Ultima Compra")]
        public string UltimaCompra { get; set; }
        [Display(Name = "Ultima Venta")]
        public string UltimaVenta { get; set; }
        public int IdImagen { get; set; }
        [Display(Name = "Clave SAT")]
        public string CveSat { get; set; }
    }
}
