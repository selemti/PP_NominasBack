using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Biometria
{
    public class LogsSincronizacionDto
    {
        [Display(Name = "ID del log de sincronización")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Dispositivo involucrado")]
        [Required]
        public List<string> DispositivoId { get; set; }

        [Display(Name = "Fecha y hora del evento de sincronización")]
        [Required]
        public List<DateTime?> FechaEvento { get; set; }

        [Display(Name = "Mensaje del evento")]
        [Required]
        public List<string> DescripcionLog { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
