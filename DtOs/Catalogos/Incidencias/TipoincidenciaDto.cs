using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class TipoIncidenciaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombreTipoIncidencia")]
        public string NombreTipoIncidencia { get; set; }

        [Required]
        [Display(Name = "DescripcionTipoIncidencia")]
        public string DescripcionTipoIncidencia { get; set; }

        [Display(Name = "RequiereJustificante")]
        public bool? RequiereJustificante { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}