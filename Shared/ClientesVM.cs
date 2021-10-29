using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaGuerrero.Shared
{
    public class ClientesVM
    {
        [Key]
        public int Id { get; set; }
        public string Curp { get; set; }
        [Display(Name = "Registro Federal de Contributentes")]
        public string Rfc { get; set; }
        [Display(Name = "Nombre del Cliente")]
        [Required(ErrorMessage = "El Nombre del Cliente es Requerido.")]
        public string Nombre { get; set; }
        public string Calle { get; set; }
        [Display(Name = "Número Exterior e Interior ")]
        public string Numero { get; set; }
        public string Colonia { get; set; }
        public string Localidad { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        [Display(Name = "Código Postal")]
        public string Cp { get; set; }
        [Display(Name = "Correo Electrónico")]
        //[Required(ErrorMessage = "El Correo Electrónico es Requerido.")]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }        
        [Display(Name = "Teléfono Móvil")]
        public string Telefono { get; set; }       
        [Display(Name = "Teléfono Oficina")]
        public string Telefono2 { get; set; }
        [Display(Name = "Atención a Cobranza")]
        public string AtnCobranza { get; set; }
        [Display(Name = "Atención en Ventas")]
        public string AtnVentas { get; set; }
        public int IdImagen { get; set; }
        [Display(Name = "Saldo")]
        public decimal Saldo { get; set; }
    }
}
