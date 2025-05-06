using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class UbicacionDto
    {
        [Display(Name = "ID de la ubicación")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre de la ubicación")]
        [Required]
        public List<string> Nombre { get; set; }

        [Display(Name = "Coordenada geográfica")]
        [Required]
        public List<decimal?> Latitud { get; set; }

        [Display(Name = "Coordenada geográfica")]
        [Required]
        public List<decimal?> Longitud { get; set; }

        [Display(Name = "Radio permitido en metros")]
        [Required]
        public List<decimal?> Radio { get; set; }

        [Display(Name = "Tipo (1=Polígono, 2=Radio)")]
        [Required]
        public List<int?> TipoUbicacion { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
