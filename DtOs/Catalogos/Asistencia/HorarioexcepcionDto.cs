using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class HorarioExcepcionDto
    {
        [Display(Name = "ID de la excepción")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado asociado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Inicio de excepción")]
        [Required]
        public List<DateTime?> FechaInicio { get; set; }

        [Display(Name = "Fin de excepción")]
        [Required]
        public List<DateTime?> FechaFin { get; set; }

        [Display(Name = "Turno alterno aplicado")]
        [Required]
        public List<string> TurnoEspecialId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
