using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class GrupoEmpresaDto
    {
        [Display(Name = "ID del grupo empresarial")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Código interno del grupo")]
        [Required]
        public List<string> Clave { get; set; }

        [Display(Name = "Nombre del grupo")]
        [Required]
        public List<string> Nombre { get; set; }

        [Display(Name = "RFC del grupo")]
        [Required]
        public List<string> Rfc { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
