using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class HorarioDto
    {
        [Display(Name = "Enum funcional extendido para RH")]
        [Required]
        public List<int?> TipoHorario { get; set; }

    }
}
