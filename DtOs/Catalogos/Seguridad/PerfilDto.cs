using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Seguridad
{
    public class PerfilDto
    {
        [Display(Name = "ID del perfil")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre del perfil")]
        [Required]
        public List<string> NombrePerfil { get; set; }

        [Display(Name = "Descripción funcional")]
        [Required]
        public List<string> DescripcionPerfil { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
