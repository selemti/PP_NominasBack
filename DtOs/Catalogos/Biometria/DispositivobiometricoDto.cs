using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Biometria
{
    public class DispositivoBiometricoDto
    {
        [Display(Name = "ID del dispositivo biométrico")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Modelo del dispositivo")]
        [Required]
        public List<string> Modelo { get; set; }

        [Display(Name = "Número de serie del dispositivo")]
        [Required]
        public List<string> NumeroSerie { get; set; }

        [Display(Name = "IP de red asignada")]
        [Required]
        public List<string> IpAsignada { get; set; }

        [Display(Name = "Tipo (0 = Biométrico, 1 = Facial, 2 = Huella)")]
        [Required]
        public List<int?> TipoDispositivo { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

        [Display(Name = "Referencia al Centro de Trabajo")]
        [Required]
        public List<string> CentroId { get; set; }

    }
}
