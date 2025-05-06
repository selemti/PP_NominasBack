using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class EmpresaCentroTrabajoDto
    {
        [Display(Name = "ID único de la relación empresa - centro de trabajo")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empresa relacionada")]
        [Required]
        public List<string> GrupoEmpresaId { get; set; }

        [Display(Name = "Centro de trabajo relacionado")]
        [Required]
        public List<string> CentroTrabajoId { get; set; }

        [Display(Name = "Indica si la relación está activa")]
        [Required]
        public List<bool?> Vigente { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
