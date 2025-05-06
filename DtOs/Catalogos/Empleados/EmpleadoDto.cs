using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Dtos.Catalogos.Shared;
using PP_NominasBack.Models.Catalogos.Empleados;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class EmpleadoDto
    {
        [Display(Name = "Id")]
        [Required]
        public string Id { get; set; }

        [Display(Name = "Persona")]
        [Required]
        public PersonaDto Persona { get; set; }

        [Display(Name = "Curp")]
        [Required]
        public string Curp { get; set; }

        [Display(Name = "Rfc")]
        [Required]
        public string Rfc { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        [Required]
        public DateTime FechaIngreso { get; set; }

        [Display(Name = "Fecha de Baja")]
        public DateTime? FechaBaja { get; set; }

        [Display(Name = "Tipo de Contrato")]
        [Required]
        public TipoContrato? TipoContrato { get; set; }

        [Display(Name = "Vigente")]
        [Required]
        public bool Vigente { get; set; }

        [Display(Name = "Registro IMSS")]
        [Required]
        public RegistroImssDto RegistroImss { get; set; }

        [Display(Name = "DatosPagoEmpleado")]
        [Required]
        public DatosPagoEmpleadoDto DatosPagoEmpleado { get; set; }

        [Display(Name = "Asignaciones de Plaza")]
        [Required]
        public List<AsignacionPlazaEmpleadoDto> AsignacionesPlaza { get; set; }

        [Display(Name = "Historial de Plazas")]
        [Required]
        public List<HistorialPlazaEmpleadoDto> HistorialPlazas { get; set; }

        [Display(Name = "Contactos de Emergencia")]
        [Required]
        public List<EmpleadoContactoDto> ContactosEmergencia { get; set; }

        [Display(Name = "Documentos")]
        [Required]
        public List<ArchivoEmpleadoDto> Documentos { get; set; }
    }
}
