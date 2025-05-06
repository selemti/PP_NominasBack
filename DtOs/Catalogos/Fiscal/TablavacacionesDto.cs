using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class TablaVacacionesDto
    {
        [Display(Name = "ID del rango de antigüedad")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Años mínimos cumplidos")]
        [Required]
        public List<int?> AniosAntiguedadMinimo { get; set; }

        [Display(Name = "Años máximos cumplidos")]
        [Required]
        public List<int?> AniosAntiguedadMaximo { get; set; }

        [Display(Name = "Días de vacaciones otorgados")]
        [Required]
        public List<int?> DiasVacaciones { get; set; }

        [Display(Name = "Año fiscal aplicable")]
        [Required]
        public List<int?> EjercicioFiscal { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
