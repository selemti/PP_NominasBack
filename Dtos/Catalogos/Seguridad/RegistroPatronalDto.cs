using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Seguridad
{
    public class RegistroPatronalDto
    {
        [Display(Name = "Nombre del registro patronal")]
        [Required]
        public List<string> Nombre { get; set; }

        [Display(Name = "RFC de la entidad patronal")]
        [Required]
        public List<string> Rfc { get; set; }

        [Display(Name = "Número oficial del registro patronal")]
        [Required]
        public List<string> NumeroRegistro { get; set; }

        [Display(Name = "Subdelegación del IMSS correspondiente")]
        [Required]
        public List<string> Subdelegacion { get; set; }

    }
}
