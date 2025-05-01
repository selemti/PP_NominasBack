using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class IncidenciaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Required]
        [Display(Name = "TipoIncidenciaId")]
        public string TipoIncidenciaId { get; set; }

        [Display(Name = "FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "FechaFin")]
        public DateTime? FechaFin { get; set; }

        [Required]
        [Display(Name = "JustificanteId")]
        public string JustificanteId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}