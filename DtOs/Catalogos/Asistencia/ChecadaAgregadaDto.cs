using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class ChecadaAgregadaDto
    {
        [Display(Name = "Id")]
        [Required]
        public string Id { get; set; }

        [Display(Name = "EmpleadoId")]
        [Required]
        public string EmpleadoId { get; set; }

        [Display(Name = "Fecha")]
        [Required]
        public DateTime Fecha { get; set; }

        [Display(Name = "HoraEntrada")]
        [Required]
        public string HoraEntrada { get; set; }

        [Display(Name = "HoraSalida")]
        [Required]
        public string HoraSalida { get; set; }

        [Display(Name = "Observaciones")]
        [Required]
        public string Observaciones { get; set; }

        [Display(Name = "Auditable")]
        [Required]
        public string Auditable { get; set; }

    }
}
