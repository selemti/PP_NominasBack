using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class OrganigramaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "DivisionId")]
        public string DivisionId { get; set; }

        [Required]
        [Display(Name = "PuestoId")]
        public string PuestoId { get; set; }

        [Required]
        [Display(Name = "CentroCostoId")]
        public string CentroCostoId { get; set; }

        [Required]
        [Display(Name = "NodoPadreId")]
        public string NodoPadreId { get; set; }

        [Display(Name = "Nivel")]
        public int? Nivel { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}