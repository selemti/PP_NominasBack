using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class DatosPagoEmpleadoDto
    {
        [Display(Name = "ID único del método de pago")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado relacionado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Banco de dispersión")]
        [Required]
        public List<string> BancoId { get; set; }

        [Display(Name = "Número de cuenta bancaria")]
        [Required]
        public List<string> CuentaBancaria { get; set; }

        [Display(Name = "Forma de pago")]
        [Required]
        public List<int?> FormaPago { get; set; }

        [Display(Name = "¿Es la forma de pago actual?")]
        [Required]
        public List<bool?> Vigente { get; set; }

        [Display(Name = "Inicio de vigencia")]
        [Required]
        public List<DateTime?> FechaInicio { get; set; }

        [Display(Name = "Fin de vigencia (nullable)")]
        [Required]
        public List<DateTime?> FechaFin { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
