using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class HistorialIncidenciaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "IncidenciaId")]
        public string IncidenciaId { get; set; }

        [Display(Name = "FechaCambio")]
        public DateTime? FechaCambio { get; set; }

        [Required]
        [Display(Name = "DescripcionCambio")]
        public string DescripcionCambio { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}