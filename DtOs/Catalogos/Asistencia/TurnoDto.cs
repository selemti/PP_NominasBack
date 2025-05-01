using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class TurnoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombreTurno")]
        public string NombreTurno { get; set; }

        [Required]
        [Display(Name = "HoraEntrada")]
        public string HoraEntrada { get; set; }

        [Required]
        [Display(Name = "HoraSalida")]
        public string HoraSalida { get; set; }

        [Display(Name = "TipoTurno")]
        public int? TipoTurno { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}