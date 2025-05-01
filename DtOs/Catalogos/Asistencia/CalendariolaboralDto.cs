using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class CalendarioLaboralDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "Fecha")]
        public DateTime? Fecha { get; set; }

        [Display(Name = "TipoDia")]
        public int? TipoDia { get; set; }

        [Required]
        [Display(Name = "DescripcionEvento")]
        public string DescripcionEvento { get; set; }

        [Required]
        [Display(Name = "EmpresaId")]
        public string EmpresaId { get; set; }

        [Required]
        [Display(Name = "DivisionId")]
        public string DivisionId { get; set; }

        [Display(Name = "Vigente")]
        public bool? Vigente { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}