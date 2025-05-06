using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    public class PersonaDto
    {
        [Display(Name = "CURP del empleado")]
        [Required]
        public List<string> Curp { get; set; }

        [Display(Name = "RFC del empleado")]
        [Required]
        public List<string> Rfc { get; set; }

        [Display(Name = "Correo electrónico del empleado")]
        [Required]
        public List<string> Email { get; set; }

        [Display(Name = "País de origen")]
        [Required]
        public List<string> Nacionalidad { get; set; }

        [Display(Name = "Domicilio de la persona")]
        [Required]
        public List<Direccion>? Direccion { get; set; }

        [Display(Name = "Teléfonos personales")]
        [Required]
        public List<List<Telefono>?> Telefonos { get; set; }

    }
}
