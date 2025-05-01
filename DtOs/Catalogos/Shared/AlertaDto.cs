using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Shared
{
    public class AlertaDto
    {
        /// Evento que genera la alerta
        public required string EventoDisparador { get; set; }

        /// Descripción de la alerta
        public required string DescripcionAlerta { get; set; }

        /// (0 = Única, 1 = Recurrente diaria, 2 = Recurrente semanal)
        [Required]
        public PeriodicidadEnum TipoPeriodicidad { get; set; }

        /// (0 = Correo, 1 = WhatsApp, 2 = Sistema Interno)
        [Required]
        public MedioEnvioEnum MedioEnvio { get; set; }

        /// Mensaje personalizado que se enviará
        public required string PlantillaMensaje { get; set; }

        /// Indica si la alerta está activa
        [Required]
        public bool Activo { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}