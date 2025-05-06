using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Configuracion
{
    public class PoliticaDto
    {
        [Display(Name = "ID de la política")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre de la política")]
        [Required]
        public List<string> NombrePolitica { get; set; }

        [Display(Name = "DescripcionPolitica")]
        [Required]
        public List<string> DescripcionPolitica { get; set; }

        [Display(Name = "Número de versión")]
        [Required]
        public List<string> VersionPolitica { get; set; }

        [Display(Name = "Fecha de inicio de vigencia")]
        [Required]
        public List<DateTime?> FechaInicioVigencia { get; set; }

        [Display(Name = "Fecha de fin de vigencia (opcional)")]
        [Required]
        public List<string> FechaFinVigencia { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
