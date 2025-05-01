using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    public class PersonaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Curp")]
        public string Curp { get; set; }

        [Required]
        [Display(Name = "Rfc")]
        public string Rfc { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "ApellidoPaterno")]
        public string ApellidoPaterno { get; set; }

        [Required]
        [Display(Name = "ApellidoMaterno")]
        public string ApellidoMaterno { get; set; }

        [Display(Name = "FechaNacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [Display(Name = "Sexo")]
        public int? Sexo { get; set; }

        [Display(Name = "EstadoCivil")]
        public int? EstadoCivil { get; set; }

        [Display(Name = "NivelEstudio")]
        public int? NivelEstudio { get; set; }

        [Display(Name = "TipoSangre")]
        public int? TipoSangre { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

    }
}