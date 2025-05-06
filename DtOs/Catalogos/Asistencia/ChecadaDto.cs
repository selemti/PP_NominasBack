
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class ChecadaDto
    {
        [Display(Name = "ID de la checada")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado que registró la checada")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Fecha y hora de la checada")]
        [Required]
        public List<DateTime?> FechaHora { get; set; }

        [Display(Name = "Tipo de evento (0 = Entrada, 1 = Salida)")]
        [Required]
        public List<int?> TipoEvento { get; set; }

        [Display(Name = "Dispositivo biométrico usado")]
        [Required]
        public List<string> DispositivoId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

        // Nueva propiedad para Horas Trabajadas
        [Display(Name = "Horas trabajadas")]
        [Required]
        public List<double?> HorasTrabajadas { get; set; }
    }
}
