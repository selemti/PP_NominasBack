using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Seguridad
{
    public class HistorialRegistroImssDto
    {
        [Display(Name = "Referencia al empleado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Número de seguridad social asignado")]
        [Required]
        public List<string> Nss { get; set; }

        [Display(Name = "Registro patronal asociado")]
        [Required]
        public List<string> RegistroPatronalId { get; set; }

        [Display(Name = "Fecha de alta en IMSS")]
        [Required]
        public List<DateTime?> FechaAlta { get; set; }

        [Display(Name = "Fecha de baja en IMSS")]
        [Required]
        public List<DateTime?> FechaBaja { get; set; }

    }
}
