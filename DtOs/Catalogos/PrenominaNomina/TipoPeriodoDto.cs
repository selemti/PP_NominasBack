using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.PrenominaNomina
{
    public class TipoPeriodoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombreTipoPeriodo")]
        public string NombreTipoPeriodo { get; set; }

        [Display(Name = "DiasPeriodo")]
        public int? DiasPeriodo { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}