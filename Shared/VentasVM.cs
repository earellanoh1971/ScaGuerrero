namespace ScaGuerrero.Shared
{
    public class VentasVM
    {
        public int Id { get; set; }
        public int? Folio { get; set; }
        public string Fecha { get; set; }
        public string FechaTimbrado { get; set; }
        public string Status { get; set; }
        public string IdCliente { get; set; }
        public string IdCiclo { get; set; }
        public string FechaVencimiento { get; set; }
        public string FormaPago { get; set; }
        public string MetodoPago { get; set; }
        public string UsoCfdi { get; set; }
        public string Uuid { get; set; }
        public string Observaciones { get; set; }
        public decimal? Anticipo { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Iva { get; set; }       
        public string Total { get; set; }
        public bool? Timbrado { get; set; }
        public string IdUsuario { get; set; }
        public string Cliente { get; set; }
        public string Ciclo { get; set; }
        public string Usuario { get; set; }

    }
}
