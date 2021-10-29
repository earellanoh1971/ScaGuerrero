using System;
using System.Collections.Generic;

namespace ScaGuerrero.Server.Models
{
    public partial class Parametros
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string UrlCertificado { get; set; }
        public string UrlKey { get; set; }
        public string Password { get; set; }
        public int? FolioVentas { get; set; }
        public int? FolioCompras { get; set; }
    }
}
