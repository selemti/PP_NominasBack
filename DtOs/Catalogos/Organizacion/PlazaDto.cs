using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class PlazaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "ClavePlaza")]
        public string ClavePlaza { get; set; }

        [Required]
        [Display(Name = "NombrePlaza")]
        public string NombrePlaza { get; set; }

        [Required]
        [Display(Name = "PuestoId")]
        public string PuestoId { get; set; }

        [Required]
        [Display(Name = "DepartamentoId")]
        public string DepartamentoId { get; set; }

        [Display(Name = "EstatusPlaza")]
        public int? EstatusPlaza { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}