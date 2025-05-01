using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class RangoToleranciaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "MinutosDesde")]
        public int? MinutosDesde { get; set; }

        [Display(Name = "MinutosHasta")]
        public int? MinutosHasta { get; set; }

        [Display(Name = "Penalizacion")]
        public bool? Penalizacion { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}