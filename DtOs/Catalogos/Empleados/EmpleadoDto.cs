using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class EmpleadoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "PersonaId")]
        public string PersonaId { get; set; }

        [Display(Name = "EstatusEmpleado")]
        public int? EstatusEmpleado { get; set; }

        [Display(Name = "FechaIngreso")]
        public DateTime? FechaIngreso { get; set; }

        [Display(Name = "FechaBaja")]
        public DateTime? FechaBaja { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}