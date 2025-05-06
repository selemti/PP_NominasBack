using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class ChecadaRemotaDto
    {
        [Display(Name = "Id")]
        [Required]
        public string Id { get; set; }

        [Display(Name = "EmpleadoId")]
        [Required]
        public string EmpleadoId { get; set; }

        [Display(Name = "FechaHora")]
        [Required]
        public DateTime FechaHora { get; set; }

        [Display(Name = "TipoEvento")]
        [Required]
        public int TipoEvento { get; set; }

        [Display(Name = "Latitud")]
        [Required]
        public decimal Latitud { get; set; }

        [Display(Name = "Longitud")]
        [Required]
        public decimal Longitud { get; set; }

        [Display(Name = "UbicacionId")]
        [Required]
        public string UbicacionId { get; set; }

        [Display(Name = "FotoAdjunta")]
        [Required]
        public string FotoAdjunta { get; set; }

        [Display(Name = "Auditable")]
        [Required]
        public string Auditable { get; set; }

    }
}
