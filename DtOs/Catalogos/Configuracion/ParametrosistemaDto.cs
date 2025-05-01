using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Configuracion
{
    public class ParametroSistemaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "ClaveParametro")]
        public string ClaveParametro { get; set; }

        [Required]
        [Display(Name = "ValorParametro")]
        public string ValorParametro { get; set; }

        [Required]
        [Display(Name = "DescripcionParametro")]
        public string DescripcionParametro { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}