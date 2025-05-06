using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class TablaImssDto
    {
        [Display(Name = "ID de la cuota IMSS")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Concepto de cuota (ej. Enfermedad y Maternidad)")]
        [Required]
        public List<string> Concepto { get; set; }

        [Display(Name = "Porcentaje de aportación patronal")]
        [Required]
        public List<decimal?> PorcentajePatronal { get; set; }

        [Display(Name = "Porcentaje de aportación del trabajador")]
        [Required]
        public List<decimal?> PorcentajeObrero { get; set; }

        [Display(Name = "Si aplica solo a salario mínimo (bool)")]
        [Required]
        public List<bool?> SalarioMinimoAplica { get; set; }

        [Display(Name = "Año fiscal aplicable")]
        [Required]
        public List<int?> EjercicioFiscal { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
