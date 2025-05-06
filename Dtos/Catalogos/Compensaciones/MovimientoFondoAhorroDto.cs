using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Compensaciones
{
    public class MovimientoFondoAhorroDto
    {
        [Display(Name = "ID del movimiento")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Fondo relacionado")]
        [Required]
        public List<string> FondoAhorroId { get; set; }

        [Display(Name = "(0 = Aportación, 1 = Retiro, 2 = Interés generado)")]
        [Required]
        public List<int?> TipoMovimiento { get; set; }

        [Display(Name = "Monto del movimiento")]
        [Required]
        public List<decimal?> Monto { get; set; }

        [Display(Name = "Fecha de operación")]
        [Required]
        public List<DateTime?> FechaMovimiento { get; set; }

        [Display(Name = "Descripción breve del movimiento")]
        [Required]
        public List<string> Descripcion { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
