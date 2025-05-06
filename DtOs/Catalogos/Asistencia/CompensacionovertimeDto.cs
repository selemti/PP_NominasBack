using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class CompensacionOvertimeDto
    {
        [Display(Name = "ID del tipo de compensación")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Código corto de compensación")]
        [Required]
        public List<string> Codigo { get; set; }

        [Display(Name = "Nombre del tipo de compensación")]
        [Required]
        public List<string> Nombre { get; set; }

        [Display(Name = "Descripción detallada")]
        [Required]
        public List<string> Descripcion { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
