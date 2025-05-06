using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Prenomina
{
    public class ControlCierrePrenominaDto
    {
        [Display(Name = "ID del cierre de prenómina")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Periodo de nómina relacionado")]
        [Required]
        public List<string> PeriodoNominaId { get; set; }

        [Display(Name = "Fecha real de cierre")]
        [Required]
        public List<DateTime?> FechaCierre { get; set; }

        [Display(Name = "Usuario que cerró el periodo")]
        [Required]
        public List<string> UsuarioCierreId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
