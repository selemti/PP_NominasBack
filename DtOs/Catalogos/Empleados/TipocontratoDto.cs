using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class TipoContratoDto
    {
        [Display(Name = "ID del tipo de contrato")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre del contrato")]
        [Required]
        public List<string> NombreContrato { get; set; }

        [Display(Name = "Descripción del tipo de contrato")]
        [Required]
        public List<string> DescripcionContrato { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
