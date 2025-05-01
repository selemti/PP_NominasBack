using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.PrenominaNomina
{
    public class HistorialValidacionDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "PeriodoNominaId")]
        public string PeriodoNominaId { get; set; }

        [Required]
        [Display(Name = "UsuarioValidadorId")]
        public string UsuarioValidadorId { get; set; }

        [Required]
        [Display(Name = "Resultado")]
        public string Resultado { get; set; }

        [Display(Name = "FechaValidacion")]
        public DateTime? FechaValidacion { get; set; }

        [Required]
        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}