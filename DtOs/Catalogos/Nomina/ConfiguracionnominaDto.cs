using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Nómina
{
    public class ConfiguracionnominaDto
    {
        /// Grupo empresarial relacionado
        public string? GrupoEmpresaId { get; set; }

        /// (0 = Quincenal, 1 = Semanal, 2 = Mensual)
        [Required]
        public TipoNominaEnum TipoNomina { get; set; }

        /// Días específicos de pago (ej: 5, 20)
        public string DiasPago { get; set; }

        /// Centro de trabajo relacionado
        public string? CentroTrabajoId { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}