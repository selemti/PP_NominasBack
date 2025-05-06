using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Biometria
{
    public class TipoEventoBiometricoDto
    {
        [Display(Name = "ID del tipo de evento")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Nombre del evento (entrada, salida, comida, etc.)")]
        [Required]
        public List<string> NombreEvento { get; set; }

        [Display(Name = "Descripción detallada del evento")]
        [Required]
        public List<string> DescripcionEvento { get; set; }

        [Display(Name = "Estatus activo del tipo de evento")]
        [Required]
        public List<bool?> Activo { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
