using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.CompensacionesDeducciones
{
    public class CatalogoCompensacionesDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "TipoCompensacion")]
        public int? TipoCompensacion { get; set; }

        [Required]
        [Display(Name = "NombreCompensacion")]
        public string NombreCompensacion { get; set; }

        [Required]
        [Display(Name = "DescripcionCompensacion")]
        public string DescripcionCompensacion { get; set; }

        [Required]
        [Display(Name = "AplicaEmpresaId")]
        public string AplicaEmpresaId { get; set; }

        [Required]
        [Display(Name = "AplicaDivisionId")]
        public string AplicaDivisionId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}