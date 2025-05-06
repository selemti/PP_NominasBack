// Dtos/Catalogos/Nomina/ConceptoFiniquitoDto.cs
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    public class ConceptoFiniquitoDto
    {
        [Display(Name = "FiniquitoLiquidacionId")]
        [Required]
        public string FiniquitoLiquidacionId { get; set; } = null!;

        [Display(Name = "Código")]
        [Required]
        public string Codigo { get; set; } = null!;

        [Display(Name = "Descripción")]
        [Required]
        public string Descripcion { get; set; } = null!;

        [Display(Name = "Es percepción")]
        public bool EsPercepcion { get; set; }

        [Display(Name = "Importe")]
        [Required]
        public decimal Importe { get; set; }
    }
}
