using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    public class DetallePercepcionesDto
    {
        [Display(Name = "ID del detalle de percepción")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Recibo de nómina asociado")]
        [Required]
        public List<string> ReciboNominaId { get; set; }

        [Display(Name = "Concepto de percepción aplicada")]
        [Required]
        public List<string> TipoCompensacionId { get; set; }

        [Display(Name = "Monto de la percepción")]
        [Required]
        public List<decimal?> Monto { get; set; }

        [Display(Name = "(0 = Gravado, 1 = Exento, 2 = Excedente)")]
        [Required]
        public List<int?> TipoFiscalizacion { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
