using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class HistorialPlazaEmpleadoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Required]
        [Display(Name = "PlazaIdAnterior")]
        public string PlazaIdAnterior { get; set; }

        [Required]
        [Display(Name = "PlazaIdNueva")]
        public string PlazaIdNueva { get; set; }

        [Display(Name = "FechaCambio")]
        public DateTime? FechaCambio { get; set; }

        [Required]
        [Display(Name = "MotivoCambio")]
        public string MotivoCambio { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}