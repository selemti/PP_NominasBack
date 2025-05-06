using MongoDB.Bson;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class CalendarioLaboralDto
    {
    public ObjectId Id { get; set; }

        [Display(Name = "ID del evento en calendario")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Fecha del evento")]
        [Required]
        public List<DateTime?> Fecha { get; set; }

        [Display(Name = "(0 = Laboral normal, 1 = Feriado oficial, 2 = Descanso especial)")]
        [Required]
        public List<int?> TipoDia { get; set; }

        [Display(Name = "Descripción breve del evento")]
        [Required]
        public List<string> DescripcionEvento { get; set; }

        [Display(Name = "Empresa relacionada (opcional)")]
        [Required]
        public List<string> EmpresaId { get; set; }

        [Display(Name = "División relacionada (opcional)")]
        [Required]
        public List<string> DivisionId { get; set; }

        [Display(Name = "Vigente")]
        [Required]
        public List<bool?> Vigente { get; set; }
    }
}
