using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.ContratosPrestaciones
{
    public class TipoContratoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "NombreContrato")]
        public string NombreContrato { get; set; }

        [Required]
        [Display(Name = "DescripcionContrato")]
        public string DescripcionContrato { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}