using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    public class DetalleDeduccionesDto
    {
        [Display(Name = "ID del detalle de deducción")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Recibo de nómina asociado")]
        [Required]
        public List<string> ReciboNominaId { get; set; }

        [Display(Name = "Concepto de deducción aplicada")]
        [Required]
        public List<string> TipoDeduccionId { get; set; }

        [Display(Name = "Monto de la deducción")]
        [Required]
        public List<decimal?> Monto { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
