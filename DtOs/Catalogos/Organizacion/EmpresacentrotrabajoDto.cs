using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class EmpresaCentroTrabajoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "GrupoEmpresaId")]
        public string GrupoEmpresaId { get; set; }

        [Required]
        [Display(Name = "CentroTrabajoId")]
        public string CentroTrabajoId { get; set; }

        [Display(Name = "Vigente")]
        public bool? Vigente { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}