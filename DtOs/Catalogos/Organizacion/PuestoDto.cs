using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organización
{
    public class PuestoDto
    {
        [Display(Name = "Enum funcional extendido para RH")]
        [Required]
        public List<int?> NivelPuesto { get; set; }

    }
}
