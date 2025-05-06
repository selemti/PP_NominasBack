using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Deducciones
{
    public class CatalogoDeduccionesDto
    {
        [Display(Name = "ID de la deducción")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "(0 = Fiscal, 1 = Crédito, 2 = Préstamo, 3 = Especial, 4 = FONACOT, 5 = Pensión Alimenticia, 6 = Otro, 7 = Multa Interna, 8 = Retención Judicial)")]
        [Required]
        public List<int?> TipoDeduccion { get; set; }

        [Display(Name = "Nombre de la deducción")]
        [Required]
        public List<string> NombreDeduccion { get; set; }

        [Display(Name = "Descripción de la deducción")]
        [Required]
        public List<string> DescripcionDeduccion { get; set; }

        [Display(Name = "Empresa aplicable")]
        [Required]
        public List<string> AplicaEmpresaId { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
