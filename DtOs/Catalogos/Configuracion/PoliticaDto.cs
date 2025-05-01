using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Configuracion
{
    public class PoliticaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombrePolitica")]
        public string NombrePolitica { get; set; }

        [Required]
        [Display(Name = "DescripcionPolitica")]
        public string DescripcionPolitica { get; set; }

        [Required]
        [Display(Name = "VersionPolitica")]
        public string VersionPolitica { get; set; }

        [Display(Name = "FechaInicioVigencia")]
        public DateTime? FechaInicioVigencia { get; set; }

        [Display(Name = "FechaFinVigencia")]
        public DateTime? FechaFinVigencia { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}