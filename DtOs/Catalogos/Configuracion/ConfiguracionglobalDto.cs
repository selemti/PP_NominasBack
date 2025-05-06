using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Configuracion
{
    public class ConfiguracionGlobalDto
    {
        [Display(Name = "ID de la configuración")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Categoría de configuración (ej. Nómina, Asistencia)")]
        [Required]
        public List<string> CategoriaConfiguracion { get; set; }

        [Display(Name = "Clave interna de configuración")]
        [Required]
        public List<string> ClaveConfiguracion { get; set; }

        [Display(Name = "ValorConfiguracion")]
        [Required]
        public List<string> ValorConfiguracion { get; set; }

        [Display(Name = "DescripcionConfiguracion")]
        [Required]
        public List<string> DescripcionConfiguracion { get; set; }

        [Display(Name = "Fecha de inicio de vigencia")]
        [Required]
        public List<DateTime?> FechaInicioVigencia { get; set; }

        [Display(Name = "Fecha de fin de vigencia (nullable)")]
        [Required]
        public List<DateTime?> FechaFinVigencia { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
