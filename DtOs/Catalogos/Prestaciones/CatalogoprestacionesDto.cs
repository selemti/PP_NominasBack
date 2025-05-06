using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Prestaciones
{
    public class CatalogoPrestacionesDto
    {
        [Display(Name = "ID de la prestación")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre de la prestación")]
        [Required]
        public List<string> NombrePrestacion { get; set; }

        [Display(Name = "DescripcionPrestacion")]
        [Required]
        public List<string> DescripcionPrestacion { get; set; }

        [Display(Name = "Empresa relacionada")]
        [Required]
        public List<string> AplicaEmpresaId { get; set; }

        [Display(Name = "División relacionada")]
        [Required]
        public List<string> AplicaDivisionId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
