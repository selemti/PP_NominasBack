using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class ChecadaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Display(Name = "FechaHora")]
        public DateTime? FechaHora { get; set; }

        [Display(Name = "TipoEvento")]
        public int? TipoEvento { get; set; }

        [Required]
        [Display(Name = "DispositivoId")]
        public string DispositivoId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}