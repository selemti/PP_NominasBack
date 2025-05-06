using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class TablaUmaDto
    {
        [Display(Name = "ID de la UMA")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Valor monetario de la UMA")]
        [Required]
        public List<decimal?> ValorUma { get; set; }

        [Display(Name = "Fecha de inicio de vigencia")]
        [Required]
        public List<DateTime?> FechaInicioVigencia { get; set; }

        [Display(Name = "Fecha fin de vigencia")]
        [Required]
        public List<DateTime?> FechaFinVigencia { get; set; }

        [Display(Name = "Año fiscal aplicable")]
        [Required]
        public List<int?> EjercicioFiscal { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
