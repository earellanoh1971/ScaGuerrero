using System;
using System.Collections.Generic;

namespace ScaGuerrero.Server.Models
{
    public partial class Contratos
    {
        public int Id { get; set; }
        public int? Folio { get; set; }
        public DateTime? Fecha { get; set; }
        public string Jurisdiccion { get; set; }
        public int? IdCliente { get; set; }
        public int? IdCiclo { get; set; }
        public string Propiedad { get; set; }
        public string Superficie { get; set; }
        public string Ejido { get; set; }
        public string Cultivo { get; set; }
        public string Variedad { get; set; }
        public string Densidad { get; set; }
        public bool? CredencialOriginal { get; set; }
        public bool? CredencialCopia { get; set; }
        public bool? Curporiginal { get; set; }
        public bool? Curpcopia { get; set; }
        public bool? CertParcelarioOriginal { get; set; }
        public bool? CertParcelarioCopia { get; set; }
        public bool? CompDomicilioOriginal { get; set; }
        public bool? CompDomicilioCopia { get; set; }
        public bool? GarantiaOriginal { get; set; }
        public bool? GarantiaCopia { get; set; }
        public string Garantia { get; set; }
        public string ObservacionesGarantia { get; set; }
        public bool? Aprobacion { get; set; }
        public bool? InsumosSemilla { get; set; }
        public bool? InsumosFertilizante { get; set; }
        public bool? InsumosAgroquimicos { get; set; }
        public bool? InsumosSeguro { get; set; }
        public string Seguro { get; set; }
        public string Observaciones { get; set; }
        public decimal? Interes { get; set; }
        public decimal? MontoCredito { get; set; }
        public DateTime? FechaVencimiento { get; set; }
    }
}
