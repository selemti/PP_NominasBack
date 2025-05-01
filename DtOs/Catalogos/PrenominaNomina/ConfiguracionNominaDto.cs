using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.PrenominaNomina
{
    public class ConfiguracionNominaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "GrupoEmpresaId")]
        public string GrupoEmpresaId { get; set; }

        [Display(Name = "TipoNomina")]
        public int? TipoNomina { get; set; }

        [Display(Name = "DiasPago")]
        public int? DiasPago { get; set; }

        [Required]
        [Display(Name = "CentroTrabajoId")]
        public string CentroTrabajoId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}