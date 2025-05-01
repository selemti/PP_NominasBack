using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    public class ContactoDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "TipoEntidad")]
        public string TipoEntidad { get; set; }

        [Required]
        [Display(Name = "EntidadId")]
        public string EntidadId { get; set; }

        [Required]
        [Display(Name = "NombreContacto")]
        public string NombreContacto { get; set; }

        [Required]
        [Display(Name = "TelefonoContacto")]
        public string TelefonoContacto { get; set; }

        [Required]
        [Display(Name = "Parentesco")]
        public string Parentesco { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}