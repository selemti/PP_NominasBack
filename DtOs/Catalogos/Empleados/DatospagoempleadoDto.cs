using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class DatosPagoEmpleadoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Required]
        [Display(Name = "BancoId")]
        public string BancoId { get; set; }

        [Required]
        [Display(Name = "CuentaBancaria")]
        public string CuentaBancaria { get; set; }

        [Display(Name = "FormaPago")]
        public int? FormaPago { get; set; }

        [Display(Name = "Vigente")]
        public bool? Vigente { get; set; }

        [Display(Name = "FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "FechaFin")]
        public DateTime? FechaFin { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}