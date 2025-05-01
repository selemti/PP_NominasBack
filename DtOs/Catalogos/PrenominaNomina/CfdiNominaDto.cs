using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.PrenominaNomina
{
    public class CfdiNominaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "ReciboNominaId")]
        public string ReciboNominaId { get; set; }

        [Required]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; }

        [Required]
        [Display(Name = "SelloDigital")]
        public string SelloDigital { get; set; }

        [Display(Name = "FechaTimbre")]
        public DateTime? FechaTimbre { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}