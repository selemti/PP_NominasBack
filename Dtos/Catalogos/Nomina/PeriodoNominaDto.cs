using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    public class PeriodoNominaDto
    {
        [Display(Name = "(0 = Administrativo, 1 = Crew, 2 = Overhead)")]
        [Required]
        public List<int?> TipoNomina { get; set; }

    }
}
