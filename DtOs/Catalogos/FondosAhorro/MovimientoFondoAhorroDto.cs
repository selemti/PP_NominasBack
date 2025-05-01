using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.FondosAhorro
{
    public class MovimientoFondoAhorroDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "FondoAhorroId")]
        public string FondoAhorroId { get; set; }

        [Display(Name = "TipoMovimiento")]
        public int? TipoMovimiento { get; set; }

        [Display(Name = "Monto")]
        public decimal? Monto { get; set; }

        [Display(Name = "FechaMovimiento")]
        public DateTime? FechaMovimiento { get; set; }

        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}