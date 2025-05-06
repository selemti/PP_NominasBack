
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Compensaciones
{
    public class EmpleadoCompensacionDto
    {
        [Display(Name = "Id")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "EmpleadoId")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "CompensacionId")]
        [Required]
        public List<string> CompensacionId { get; set; }

        [Display(Name = "Valor")]
        [Required]
        public List<decimal?> Valor { get; set; }

        [Display(Name = "Tipo de asignación")]
        [Required]
        public List<int?> TipoAsignacion { get; set; }

        [Display(Name = "Fórmula de cálculo")]
        [Required]
        public List<string> Formula { get; set; }

        [Display(Name = "Periodicidad")]
        [Required]
        public List<int?> Periodicidad { get; set; }

        [Display(Name = "Fecha inicio")]
        [Required]
        public List<DateTime?> FechaInicio { get; set; }

        [Display(Name = "Fecha fin")]
        [Required]
        public List<DateTime?> FechaFin { get; set; }

        [Display(Name = "Vigente")]
        [Required]
        public List<bool?> Vigente { get; set; }

        [Display(Name = "Auditable")]
        [Required]
        public List<Auditable?> Auditable { get; set; }
    }
}
