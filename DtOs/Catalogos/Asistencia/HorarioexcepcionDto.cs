using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class HorarioExcepcionDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Display(Name = "FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "FechaFin")]
        public DateTime? FechaFin { get; set; }

        [Required]
        [Display(Name = "TurnoEspecialId")]
        public string TurnoEspecialId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}