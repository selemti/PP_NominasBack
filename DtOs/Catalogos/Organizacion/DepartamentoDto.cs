using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class DepartamentoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "ClaveDepartamento")]
        public string ClaveDepartamento { get; set; }

        [Required]
        [Display(Name = "NombreDepartamento")]
        public string NombreDepartamento { get; set; }

        [Required]
        [Display(Name = "DivisionId")]
        public string DivisionId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}