using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    public class DireccionDto
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
        [Display(Name = "Calle")]
        public string Calle { get; set; }

        [Required]
        [Display(Name = "NumeroExterior")]
        public string NumeroExterior { get; set; }

        [Required]
        [Display(Name = "NumeroInterior")]
        public string NumeroInterior { get; set; }

        [Required]
        [Display(Name = "Colonia")]
        public string Colonia { get; set; }

        [Required]
        [Display(Name = "Municipio")]
        public string Municipio { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required]
        [Display(Name = "CodigoPostal")]
        public string CodigoPostal { get; set; }

        [Required]
        [Display(Name = "Pais")]
        public string Pais { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}