using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Compensaciones
{
    public class CatalogoCompensacionesDto
    {
        [Display(Name = "ID de la compensación")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Tipo (0 = Bono, 1 = Comisión, 2 = Premio)")]
        [Required]
        public List<int?> TipoCompensacion { get; set; }

        [Display(Name = "Nombre del concepto")]
        [Required]
        public List<string> NombreCompensacion { get; set; }

        [Display(Name = "DescripcionCompensacion")]
        [Required]
        public List<string> DescripcionCompensacion { get; set; }

        [Display(Name = "Empresa relacionada (opcional)")]
        [Required]
        public List<string> AplicaEmpresaId { get; set; }

        [Display(Name = "División relacionada (opcional)")]
        [Required]
        public List<string> AplicaDivisionId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
