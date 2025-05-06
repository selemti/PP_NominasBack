using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Incidencias
{
    public class HistorialIncidenciaDto
    {
        [Display(Name = "ID del historial de cambios")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Incidencia relacionada")]
        [Required]
        public List<string> IncidenciaId { get; set; }

        [Display(Name = "Fecha del cambio registrado")]
        [Required]
        public List<DateTime?> FechaCambio { get; set; }

        [Display(Name = "Descripción del cambio realizado")]
        [Required]
        public List<string> DescripcionCambio { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
