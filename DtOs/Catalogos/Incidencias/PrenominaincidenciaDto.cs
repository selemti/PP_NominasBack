using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class PreNominaIncidenciaDto
    {
        [Display(Name = "ID de la incidencia ObjectId")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado afectado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Periodo en que se aplicará la incidencia")]
        [Required]
        public List<string> PeriodoNominaId { get; set; }

        [Display(Name = "Tipo de incidencia aplicada")]
        [Required]
        public List<string> TipoIncidenciaId { get; set; }

        [Display(Name = "Fecha en que se aplica")]
        [Required]
        public List<DateTime?> Fecha { get; set; }

        [Display(Name = "Duración en horas o días")]
        [Required]
        public List<decimal?> Duracion { get; set; }

        [Display(Name = "URL del documento (si aplica)")]
        [Required]
        public List<string> JustificanteAdjunto { get; set; }

        [Display(Name = "Aprobada, Pendiente, Rechazada")]
        [Required]
        public List<string> Estatus { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
