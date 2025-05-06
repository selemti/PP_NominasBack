using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class EmpleadoContactoDto
    {
        [Display(Name = "ID del contacto")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "ID del empleado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Nombre completo del contacto")]
        [Required]
        public List<string> NombreContacto { get; set; }

        [Display(Name = "Parentesco (enum)")]
        [Required]
        public List<int?> Parentesco { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
