using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class ChecadaRemotaDto
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

        [Display(Name = "Latitud")]
        public decimal? Latitud { get; set; }

        [Display(Name = "Longitud")]
        public decimal? Longitud { get; set; }

        [Required]
        [Display(Name = "UbicacionId")]
        public string UbicacionId { get; set; }

        [Required]
        [Display(Name = "FotoAdjunta")]
        public string FotoAdjunta { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}