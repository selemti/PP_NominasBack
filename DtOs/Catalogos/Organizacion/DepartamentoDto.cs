using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class DepartamentoDto
    {
        [Display(Name = "ID del departamento")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Código del departamento")]
        [Required]
        public List<string> ClaveDepartamento { get; set; }

        [Display(Name = "Nombre del departamento")]
        [Required]
        public List<string> NombreDepartamento { get; set; }

        [Display(Name = "División a la que pertenece")]
        [Required]
        public List<string> DivisionId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
