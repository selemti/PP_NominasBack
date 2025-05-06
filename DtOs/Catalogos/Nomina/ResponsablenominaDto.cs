using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    public class ResponsableNominaDto
    {
        [Display(Name = "ID del responsable")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Usuario que ejecuta o valida nómina")]
        [Required]
        public List<string> UsuarioId { get; set; }

        [Display(Name = "Tipo (0 = Ejecutor, 1 = Validador)")]
        [Required]
        public List<int?> TipoResponsabilidad { get; set; }

        [Display(Name = "Centro de pago relacionado")]
        [Required]
        public List<string> CentroPagoNominaId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
