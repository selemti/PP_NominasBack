using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class ChecadaAgregadaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Display(Name = "Fecha")]
        public DateTime? Fecha { get; set; }

        [Required]
        [Display(Name = "HoraEntrada")]
        public string HoraEntrada { get; set; }

        [Required]
        [Display(Name = "HoraSalida")]
        public string HoraSalida { get; set; }

        [Required]
        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}