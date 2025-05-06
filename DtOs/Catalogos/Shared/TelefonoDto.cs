using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    public class TelefonoDto
    {
        [Display(Name = "ID del teléfono")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Código del tipo de entidad asociada")]
        [Required]
        public List<string> TipoEntidad { get; set; }

        [Display(Name = "ID de la entidad asociada")]
        [Required]
        public List<string> EntidadId { get; set; }

        [Display(Name = "Código de país telefónico")]
        [Required]
        public List<string> ClavePais { get; set; }

        [Display(Name = "Número de teléfono principal")]
        [Required]
        public List<string> NumeroTelefonico { get; set; }

        [Display(Name = "Número de extensión")]
        [Required]
        public List<string> Extension { get; set; }

        [Display(Name = "Tipo de teléfono")]
        [Required]
        public List<int?> TipoTelefono { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
