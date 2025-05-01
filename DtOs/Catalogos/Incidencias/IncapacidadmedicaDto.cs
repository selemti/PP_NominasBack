using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class IncapacidadMedicaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Display(Name = "TipoIncapacidad")]
        public int? TipoIncapacidad { get; set; }

        [Display(Name = "DiasIncapacidad")]
        public int? DiasIncapacidad { get; set; }

        [Required]
        [Display(Name = "FolioImss")]
        public string FolioImss { get; set; }

        [Display(Name = "FechaInicio")]
        public DateTime? FechaInicio { get; set; }

        [Display(Name = "FechaFin")]
        public DateTime? FechaFin { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}