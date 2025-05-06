using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Configuracion
{
    public class ModuloDto
    {
        [Display(Name = "ID del módulo")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre del módulo")]
        [Required]
        public List<string> Nombre { get; set; }

        [Display(Name = "Descripción del módulo")]
        [Required]
        public List<string> Descripcion { get; set; }

        [Display(Name = "Indica si está habilitado")]
        [Required]
        public List<bool?> Activo { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
