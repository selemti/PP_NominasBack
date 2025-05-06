using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Compensaciones
{
    public class TabuladorSalarialDto
    {
        [Display(Name = "ID del tabulador")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Puesto relacionado")]
        [Required]
        public List<string> PuestoId { get; set; }

        [Display(Name = "Salario mínimo para puesto")]
        [Required]
        public List<decimal?> SalarioMinimo { get; set; }

        [Display(Name = "Salario máximo para puesto")]
        [Required]
        public List<decimal?> SalarioMaximo { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
