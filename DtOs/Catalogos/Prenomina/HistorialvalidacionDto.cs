using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Prenomina
{
    public class HistorialValidacionDto
    {
        [Display(Name = "ID del registro de validación")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Periodo de nómina validado")]
        [Required]
        public List<string> PeriodoNominaId { get; set; }

        [Display(Name = "Usuario que realizó la validación")]
        [Required]
        public List<string> UsuarioValidadorId { get; set; }

        [Display(Name = "Resultado (Aprobado, Rechazado)")]
        [Required]
        public List<string> Resultado { get; set; }

        [Display(Name = "Timestamp de validación")]
        [Required]
        public List<DateTime?> FechaValidacion { get; set; }

        [Display(Name = "Comentarios de validación")]
        [Required]
        public List<string> Observaciones { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
