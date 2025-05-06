using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organización
{
    public class HistorialUbicacionEmpleadoDto
    {
        [Display(Name = "Empleado asignado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Ubicación asignada")]
        [Required]
        public List<string> UbicacionId { get; set; }

        [Display(Name = "Inicio de asignación")]
        [Required]
        public List<DateTime?> FechaInicio { get; set; }

        [Display(Name = "Fin de asignación")]
        [Required]
        public List<DateTime?> FechaFin { get; set; }

    }
}
