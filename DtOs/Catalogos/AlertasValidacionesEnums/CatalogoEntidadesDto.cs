using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.AlertasValidacionesEnums
{
    public class CatalogoEntidadesDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EntityCode")]
        public string EntityCode { get; set; }

        [Required]
        [Display(Name = "NombreEntidad")]
        public string NombreEntidad { get; set; }

        [Required]
        [Display(Name = "ModuloRelacionado")]
        public string ModuloRelacionado { get; set; }

        [Required]
        [Display(Name = "DescripcionEntidad")]
        public string DescripcionEntidad { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}