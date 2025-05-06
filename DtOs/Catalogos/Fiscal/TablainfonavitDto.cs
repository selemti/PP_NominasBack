using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Fiscal
{
    public class TablaInfonavitDto
    {
        [Display(Name = "ID de tabla de Infonavit")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Tipo (0 = Factor Salario, 1 = Cuota Fija)")]
        [Required]
        public List<int?> TipoDescuento { get; set; }

        [Display(Name = "Valor aplicable del descuento")]
        [Required]
        public List<decimal?> ValorDescuento { get; set; }

        [Display(Name = "Descripción adicional")]
        [Required]
        public List<string> Descripcion { get; set; }

        [Display(Name = "Año fiscal aplicable")]
        [Required]
        public List<int?> EjercicioFiscal { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
