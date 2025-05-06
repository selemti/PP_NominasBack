using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class TipoArchivoEmpleadoDto
    {
        [Display(Name = "ID del tipo de archivo")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Código corto del tipo")]
        [Required]
        public List<string> Codigo { get; set; }

        [Display(Name = "Nombre del documento")]
        [Required]
        public List<string> Nombre { get; set; }

        [Display(Name = "Es obligatorio cargarlo")]
        [Required]
        public List<bool?> Requerido { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
