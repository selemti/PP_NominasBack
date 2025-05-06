using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class DivisionDto
    {
        [Display(Name = "ID de la división")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Grupo empresarial al que pertenece")]
        [Required]
        public List<string> GrupoEmpresaId { get; set; }

        [Display(Name = "Código de la división")]
        [Required]
        public List<string> ClaveDivision { get; set; }

        [Display(Name = "Nombre de la división")]
        [Required]
        public List<string> NombreDivision { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
