using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    public class TelefonoDto
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
        [Display(Name = "ClavePais")]
        public string ClavePais { get; set; }

        [Required]
        [Display(Name = "NumeroTelefonico")]
        public string NumeroTelefonico { get; set; }

        [Required]
        [Display(Name = "Extension")]
        public string Extension { get; set; }

        [Display(Name = "TipoTelefono")]
        public int? TipoTelefono { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}