using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    public class DireccionDto
    {
        [Display(Name = "Nombre de la calle")]
        [Required]
        public List<string> Calle { get; set; }

        [Display(Name = "Número exterior")]
        [Required]
        public List<string> NumeroExterior { get; set; }

    }
}
