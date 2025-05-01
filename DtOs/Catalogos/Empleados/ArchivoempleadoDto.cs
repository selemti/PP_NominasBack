using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class ArchivoEmpleadoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Display(Name = "TipoArchivo")]
        public int? TipoArchivo { get; set; }

        [Required]
        [Display(Name = "UrlArchivo")]
        public string UrlArchivo { get; set; }

        [Display(Name = "FechaCarga")]
        public DateTime? FechaCarga { get; set; }

        [Display(Name = "Vigente")]
        public bool? Vigente { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}