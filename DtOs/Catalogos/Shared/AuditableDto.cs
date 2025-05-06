using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    public class AuditableDto
    {
        [Display(Name = "Fecha de creación del registro")]
        [Required]
        public List<DateTime?> FechaCreacion { get; set; }

        [Display(Name = "Fecha de última modificación")]
        [Required]
        public List<DateTime?> FechaModificacion { get; set; }

        [Display(Name = "Usuario que creó el registro")]
        [Required]
        public List<string> UsuarioCreadorId { get; set; }

        [Display(Name = "Usuario que modificó el registro")]
        [Required]
        public List<string> UsuarioModificadorId { get; set; }

    }
}
