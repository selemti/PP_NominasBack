using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.CompensacionesDeducciones
{
    public class CatalogoPrestacionesDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombrePrestacion")]
        public string NombrePrestacion { get; set; }

        [Required]
        [Display(Name = "DescripcionPrestacion")]
        public string DescripcionPrestacion { get; set; }

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