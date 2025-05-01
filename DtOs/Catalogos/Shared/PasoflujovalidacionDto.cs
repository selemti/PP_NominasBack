using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Shared
{
    public class PasoflujovalidacionDto
    {
        /// Flujo al que pertenece el paso
        public string? FlujoValidacionId { get; set; }

        /// Orden secuencial del paso
        public string OrdenPaso { get; set; }

        /// Tipo de responsable (0 = Usuario individual, 1 = Rol, 2 = Área/Departamento)
        [Required]
        public TipoResponsableEnum TipoResponsable { get; set; }

        /// ID del responsable asignado
        public string? ResponsableId { get; set; }

        /// ¿Este paso requiere aceptación explícita?
        [Required]
        public bool AutorizacionNecesaria { get; set; }

        /// ¿Se debe enviar notificación en este paso?
        [Required]
        public bool NotificarEnEstePaso { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}