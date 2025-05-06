using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    public class CentroPagoNominaDto
    {
        [Display(Name = "ID del centro de pago")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre del centro de pago")]
        [Required]
        public List<string> NombreCentroPago { get; set; }

        [Display(Name = "Fecha de corte quincena 1")]
        [Required]
        public List<int?> FechaCorteQuincena1 { get; set; }

        [Display(Name = "Fecha de corte quincena 2")]
        [Required]
        public List<int?> FechaCorteQuincena2 { get; set; }

        [Display(Name = "FechaPagoQuincena1")]
        [Required]
        public List<int?> FechaPagoQuincena1 { get; set; }

        [Display(Name = "FechaPagoQuincena2")]
        [Required]
        public List<int?> FechaPagoQuincena2 { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
