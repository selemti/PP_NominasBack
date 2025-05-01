using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.AlertasValidacionesEnums
{
    public class PasoFlujoValidacionDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "FlujoValidacionId")]
        public string FlujoValidacionId { get; set; }

        [Display(Name = "OrdenPaso")]
        public int? OrdenPaso { get; set; }

        [Display(Name = "TipoResponsable")]
        public int? TipoResponsable { get; set; }

        [Required]
        [Display(Name = "ResponsableId")]
        public string ResponsableId { get; set; }

        [Display(Name = "AutorizacionNecesaria")]
        public bool? AutorizacionNecesaria { get; set; }

        [Display(Name = "NotificarEnEstePaso")]
        public bool? NotificarEnEstePaso { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}