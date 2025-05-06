using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class PlantillaTurnoDetalleDto
    {
        [Display(Name = "ID del detalle de turno")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "ID de la plantilla base mensual")]
        [Required]
        public List<string> PlantillaId { get; set; }

        [Display(Name = "Fecha del turno asignado")]
        [Required]
        public List<DateTime?> Fecha { get; set; }

        [Display(Name = "Turno aplicado ese día")]
        [Required]
        public List<string> TurnoId { get; set; }

        [Display(Name = "Plaza a la que se asigna el turno")]
        [Required]
        public List<string> PlazaId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
