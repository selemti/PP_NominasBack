using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Compensaciones
{
    public class FondoAhorroDto
    {
        [Display(Name = "ID del fondo de ahorro")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado participante")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Saldo acumulado")]
        [Required]
        public List<decimal?> SaldoActual { get; set; }

        [Display(Name = "PorcentajeAportacion")]
        [Required]
        public List<decimal?> PorcentajeAportacion { get; set; }

        [Display(Name = "Fondo activo o cerrado")]
        [Required]
        public List<bool?> Vigente { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
