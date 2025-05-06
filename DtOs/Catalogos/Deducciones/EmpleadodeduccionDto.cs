using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Deducciones
{
    public class EmpleadoDeduccionDto
    {
        [Display(Name = "ID de la asignación")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado afectado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Deducción aplicada")]
        [Required]
        public List<string> DeduccionId { get; set; }

        [Display(Name = "Valor a deducir")]
        [Required]
        public List<decimal?> Valor { get; set; }

        [Display(Name = "(0 = Única, 1 = Mensual, 2 = Quincenal)")]
        [Required]
        public List<int?> Periodicidad { get; set; }

        [Display(Name = "Inicio de la deducción")]
        [Required]
        public List<DateTime?> FechaInicio { get; set; }

        [Display(Name = "Fin (nullable)")]
        [Required]
        public List<DateTime?> FechaFin { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
