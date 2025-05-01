using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.ControlPago
{
    public class CentroPagoNominaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombreCentroPago")]
        public string NombreCentroPago { get; set; }

        [Display(Name = "FechaCorteQuincena1")]
        public int? FechaCorteQuincena1 { get; set; }

        [Display(Name = "FechaCorteQuincena2")]
        public int? FechaCorteQuincena2 { get; set; }

        [Display(Name = "FechaPagoQuincena1")]
        public int? FechaPagoQuincena1 { get; set; }

        [Display(Name = "FechaPagoQuincena2")]
        public int? FechaPagoQuincena2 { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}