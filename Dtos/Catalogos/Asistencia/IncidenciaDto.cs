
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class IncidenciaDto
    {
        [Display(Name = "Tipo de Incidencia")]
        [Required]
        public List<int?> TipoFalta { get; set; } // Tipo de incidencia (Falta, Retardo, Permiso)

        [Display(Name = "ID de la Checada asociada")]
        [Required]
        public string ChecadaId { get; set; } // Relación con la checada

        [Display(Name = "Estatus de la Incidencia")]
        [Required]
        public string EstatusIncidencia { get; set; } // Estado de la incidencia

        [Display(Name = "Duración del Retardo (en horas)")]
        public double? DuracionRetardo { get; set; } // Duración del retardo

        [Display(Name = "Justificación de la Incidencia")]
        [Required]
        public string Justificacion { get; set; } // Justificación de la incidencia

        [Display(Name = "Tipo de Permiso")]
        [Required]
        public string TipoPermiso { get; set; } // Tipo de permiso (enfermedad, vacaciones, etc.)
    }
}
