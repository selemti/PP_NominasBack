using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class TablaIsrDto
    {
        [Display(Name = "ID del rango de ISR")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Límite inferior del rango")]
        [Required]
        public List<decimal?> LimiteInferior { get; set; }

        [Display(Name = "Límite superior del rango")]
        [Required]
        public List<decimal?> LimiteSuperior { get; set; }

        [Display(Name = "Cuota fija aplicable")]
        [Required]
        public List<decimal?> CuotaFija { get; set; }

        [Display(Name = "Porcentaje aplicable al excedente")]
        [Required]
        public List<decimal?> PorcentajeExcedente { get; set; }

        [Display(Name = "Periodo aplicable (0 = Diario, 1 = Semanal, 2 = Quincenal, 3 = Mensual)")]
        [Required]
        public List<int?> Periodo { get; set; }

        [Display(Name = "Año fiscal aplicable")]
        [Required]
        public List<int?> EjercicioFiscal { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
