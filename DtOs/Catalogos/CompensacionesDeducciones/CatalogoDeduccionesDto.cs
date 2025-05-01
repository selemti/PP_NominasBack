using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.CompensacionesDeducciones
{
    public class CatalogoDeduccionesDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Display(Name = "TipoDeduccion")]
        public int? TipoDeduccion { get; set; }

        [Required]
        [Display(Name = "NombreDeduccion")]
        public string NombreDeduccion { get; set; }

        [Required]
        [Display(Name = "DescripcionDeduccion")]
        public string DescripcionDeduccion { get; set; }

        [Required]
        [Display(Name = "AplicaEmpresaId")]
        public string AplicaEmpresaId { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}