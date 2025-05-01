using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Configuracion
{
    public class ConfiguracionGlobalDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "CategoriaConfiguracion")]
        public string CategoriaConfiguracion { get; set; }

        [Required]
        [Display(Name = "ClaveConfiguracion")]
        public string ClaveConfiguracion { get; set; }

        [Required]
        [Display(Name = "ValorConfiguracion")]
        public string ValorConfiguracion { get; set; }

        [Required]
        [Display(Name = "DescripcionConfiguracion")]
        public string DescripcionConfiguracion { get; set; }

        [Display(Name = "FechaInicioVigencia")]
        public DateTime? FechaInicioVigencia { get; set; }

        [Display(Name = "FechaFinVigencia")]
        public DateTime? FechaFinVigencia { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}