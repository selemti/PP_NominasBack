using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Seguridad
{
    public class UsuarioDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombreUsuario")]
        public string NombreUsuario { get; set; }

        [Required]
        [Display(Name = "CorreoElectronico")]
        public string CorreoElectronico { get; set; }

        [Required]
        [Display(Name = "PerfilId")]
        public string PerfilId { get; set; }

        [Display(Name = "EstatusUsuario")]
        public int? EstatusUsuario { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}