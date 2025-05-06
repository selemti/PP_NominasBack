using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class IncapacidadMedicaDto
    {
        [Display(Name = "ID único de la incapacidad")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado afectado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Tipo (0 = Enfermedad, 1 = Maternidad, 2 = Riesgo)")]
        [Required]
        public List<int?> TipoIncapacidad { get; set; }

        [Display(Name = "Días autorizados por el IMSS")]
        [Required]
        public List<int?> DiasIncapacidad { get; set; }

        [Display(Name = "Folio de validación ante IMSS")]
        [Required]
        public List<string> FolioImss { get; set; }

        [Display(Name = "Fecha de inicio de la incapacidad")]
        [Required]
        public List<DateTime?> FechaInicio { get; set; }

        [Display(Name = "Fecha de fin de la incapacidad")]
        [Required]
        public List<DateTime?> FechaFin { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
