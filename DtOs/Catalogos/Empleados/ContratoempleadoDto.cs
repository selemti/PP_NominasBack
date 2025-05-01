using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class ContratoEmpleadoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Display(Name = "TipoContrato")]
        public int? TipoContrato { get; set; }

        [Display(Name = "FechaInicioContrato")]
        public DateTime? FechaInicioContrato { get; set; }

        [Display(Name = "FechaFinContrato")]
        public DateTime? FechaFinContrato { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}