using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    public class ContactoDto
    {
        [Display(Name = "ID del contacto")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Código de entidad relacionada")]
        [Required]
        public List<string> TipoEntidad { get; set; }

        [Display(Name = "ID de la entidad relacionada")]
        [Required]
        public List<string> EntidadId { get; set; }

        [Display(Name = "Nombre del contacto")]
        [Required]
        public List<string> NombreContacto { get; set; }

        [Display(Name = "Teléfono de contacto")]
        [Required]
        public List<string> TelefonoContacto { get; set; }

        [Display(Name = "Parentesco o relación")]
        [Required]
        public List<string> Parentesco { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
