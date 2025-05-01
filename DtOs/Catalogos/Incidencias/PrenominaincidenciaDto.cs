using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class PreNominaIncidenciaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Required]
        [Display(Name = "PeriodoNominaId")]
        public string PeriodoNominaId { get; set; }

        [Required]
        [Display(Name = "TipoIncidenciaId")]
        public string TipoIncidenciaId { get; set; }

        [Display(Name = "Fecha")]
        public DateTime? Fecha { get; set; }

        [Display(Name = "Duracion")]
        public decimal? Duracion { get; set; }

        [Required]
        [Display(Name = "JustificanteAdjunto")]
        public string JustificanteAdjunto { get; set; }

        [Required]
        [Display(Name = "Estatus")]
        public string Estatus { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}