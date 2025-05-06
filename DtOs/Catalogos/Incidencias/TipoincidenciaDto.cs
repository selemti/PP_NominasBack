using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class TipoIncidenciaDto
    {
        [Display(Name = "ID del tipo de incidencia")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre del tipo (Incapacidad, Permiso, etc.)")]
        [Required]
        public List<string> NombreTipoIncidencia { get; set; }

        [Display(Name = "Descripción breve del tipo")]
        [Required]
        public List<string> DescripcionTipoIncidencia { get; set; }

        [Display(Name = "Indica si necesita documento")]
        [Required]
        public List<bool?> RequiereJustificante { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
