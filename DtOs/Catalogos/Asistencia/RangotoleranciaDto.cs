using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Asistencia
{
    public class RangoToleranciaDto
    {
        [Display(Name = "ID del rango")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Código del rango")]
        [Required]
        public List<string> Codigo { get; set; }

        [Display(Name = "Nombre descriptivo")]
        [Required]
        public List<string> Nombre { get; set; }

        [Display(Name = "Minutos desde que inicia el rango")]
        [Required]
        public List<int?> MinutosDesde { get; set; }

        [Display(Name = "Minutos hasta donde termina el rango")]
        [Required]
        public List<int?> MinutosHasta { get; set; }

        [Display(Name = "¿Aplica descuento? (true/false)")]
        [Required]
        public List<bool?> Penalizacion { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
