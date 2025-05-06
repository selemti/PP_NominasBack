using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Prenomina
{
    public class TipoPeriodoDto
    {
        [Display(Name = "ID del tipo de periodo")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre descriptivo (Quincenal, Semanal)")]
        [Required]
        public List<string> NombreTipoPeriodo { get; set; }

        [Display(Name = "Número de días en el periodo")]
        [Required]
        public List<int?> DiasPeriodo { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
