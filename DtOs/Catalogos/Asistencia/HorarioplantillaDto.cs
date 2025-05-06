using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class HorarioPlantillaDto
    {
        [Display(Name = "ID de la plantilla de horarios")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre de la plantilla")]
        [Required]
        public List<string> NombrePlantilla { get; set; }

        [Display(Name = "Descripción breve del horario")]
        [Required]
        public List<string> DescripcionPlantilla { get; set; }

        [Display(Name = "Turno base de la plantilla")]
        [Required]
        public List<string> TurnoId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
