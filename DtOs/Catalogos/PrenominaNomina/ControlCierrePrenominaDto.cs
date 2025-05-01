using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.PrenominaNomina
{
    public class ControlCierrePrenominaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "PeriodoNominaId")]
        public string PeriodoNominaId { get; set; }

        [Display(Name = "FechaCierre")]
        public DateTime? FechaCierre { get; set; }

        [Required]
        [Display(Name = "UsuarioCierreId")]
        public string UsuarioCierreId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}