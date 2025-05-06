using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    public class ConfiguracionNominaDto
    {
        [Display(Name = "ID de configuración")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Grupo empresarial relacionado")]
        [Required]
        public List<string> GrupoEmpresaId { get; set; }

        [Display(Name = "(0 = Quincenal, 1 = Semanal, 2 = Mensual)")]
        [Required]
        public List<int?> TipoNomina { get; set; }

        [Display(Name = "Días específicos de pago (ej: 5, 20)")]
        [Required]
        public List<List<int>?> DiasPago { get; set; }

        [Display(Name = "Centro de trabajo relacionado")]
        [Required]
        public List<string> CentroTrabajoId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
