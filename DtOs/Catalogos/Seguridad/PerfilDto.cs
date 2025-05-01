using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Seguridad
{
    public class PerfilDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombrePerfil")]
        public string NombrePerfil { get; set; }

        [Required]
        [Display(Name = "DescripcionPerfil")]
        public string DescripcionPerfil { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}