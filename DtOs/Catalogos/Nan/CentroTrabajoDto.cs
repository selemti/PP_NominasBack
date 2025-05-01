using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Nan
{
    public class CentroTrabajoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombreCentroTrabajo")]
        public string NombreCentroTrabajo { get; set; }

        [Required]
        [Display(Name = "ClaveCentroTrabajo")]
        public string ClaveCentroTrabajo { get; set; }

        [Required]
        [Display(Name = "DireccionId")]
        public string DireccionId { get; set; }

        [Required]
        [Display(Name = "RegistroPatronal")]
        public string RegistroPatronal { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}