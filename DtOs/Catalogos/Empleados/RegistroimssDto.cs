using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class RegistroImssDto
    {
        [Display(Name = "ID del registro")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado relacionado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Fecha de alta ante IMSS")]
        [Required]
        public List<DateTime?> FechaAlta { get; set; }

        [Display(Name = "Fecha de baja ante IMSS")]
        [Required]
        public List<DateTime?> FechaBaja { get; set; }

        [Display(Name = "Número de Seguridad Social")]
        [Required]
        public List<string> Nss { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
