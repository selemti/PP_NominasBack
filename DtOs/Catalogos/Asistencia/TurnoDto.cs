using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class TurnoDto
    {
        [Display(Name = "ID único del turno")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre del turno")]
        [Required]
        public List<string> NombreTurno { get; set; }

        [Display(Name = "Hora programada de entrada")]
        [Required]
        public List<string> HoraEntrada { get; set; }

        [Display(Name = "Hora programada de salida")]
        [Required]
        public List<string> HoraSalida { get; set; }

        [Display(Name = "Tipo de turno (0 = Fijo, 1 = Flexible)")]
        [Required]
        public List<int?> TipoTurno { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
