using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class PuestoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "ClavePuesto")]
        public string ClavePuesto { get; set; }

        [Required]
        [Display(Name = "NombrePuesto")]
        public string NombrePuesto { get; set; }

        [Required]
        [Display(Name = "DescripcionPuesto")]
        public string DescripcionPuesto { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}