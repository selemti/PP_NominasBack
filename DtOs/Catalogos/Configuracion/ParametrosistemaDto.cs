using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Configuracion
{
    public class ParametroSistemaDto
    {
        [Display(Name = "ID del parámetro")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Clave única del parámetro")]
        [Required]
        public List<string> ClaveParametro { get; set; }

        [Display(Name = "Valor configurado")]
        [Required]
        public List<string> ValorParametro { get; set; }

        [Display(Name = "Descripción del parámetro")]
        [Required]
        public List<string> DescripcionParametro { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
