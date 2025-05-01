using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class DivisionDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "GrupoEmpresaId")]
        public string GrupoEmpresaId { get; set; }

        [Required]
        [Display(Name = "ClaveDivision")]
        public string ClaveDivision { get; set; }

        [Required]
        [Display(Name = "NombreDivision")]
        public string NombreDivision { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}