using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class ArchivoEmpleadoDto
    {
        [Display(Name = "ID del archivo")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado relacionado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Tipo de documento (CURP, RFC, Foto, etc.)")]
        [Required]
        public List<int?> TipoArchivo { get; set; }

        [Display(Name = "URL del archivo digitalizado")]
        [Required]
        public List<string> UrlArchivo { get; set; }

        [Display(Name = "Fecha de carga del archivo")]
        [Required]
        public List<DateTime?> FechaCarga { get; set; }

        [Display(Name = "Indica si el archivo sigue válido")]
        [Required]
        public List<bool?> Vigente { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
