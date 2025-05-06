using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Seguridad
{
    public class UsuarioDto
    {
        [Display(Name = "ID del usuario")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre de login")]
        [Required]
        public List<string> NombreUsuario { get; set; }

        [Display(Name = "Correo corporativo")]
        [Required]
        public List<string> CorreoElectronico { get; set; }

        [Display(Name = "Perfil asignado")]
        [Required]
        public List<string> PerfilId { get; set; }

        [Display(Name = "Estatus de cuenta")]
        [Required]
        public List<int?> EstatusUsuario { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
