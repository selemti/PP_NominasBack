using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class HoraCategoriaDto
    {
        [Display(Name = "ID de la categoría")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Código de categoría")]
        [Required]
        public List<string> Codigo { get; set; }

        [Display(Name = "Nombre legible de categoría")]
        [Required]
        public List<string> Nombre { get; set; }

        [Display(Name = "Descripción extendida")]
        [Required]
        public List<string> Descripcion { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
