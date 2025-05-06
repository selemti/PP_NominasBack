using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Vacaciones
{
    public class PermisoDto
    {
        [Display(Name = "ID de la solicitud de permiso")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado que solicita permiso")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Tipo de permiso (0 = Con goce, 1 = Sin goce, 2 = Otro)")]
        [Required]
        public List<int?> TipoPermiso { get; set; }

        [Display(Name = "Fecha inicial del permiso")]
        [Required]
        public List<DateTime?> FechaInicio { get; set; }

        [Display(Name = "Fecha final del permiso")]
        [Required]
        public List<DateTime?> FechaFin { get; set; }

        [Display(Name = "¿Se requiere suplente?")]
        [Required]
        public List<bool?> RequiereSuplente { get; set; }

        [Display(Name = "Tipo de reposición (0 = No repone, 1 = Mismo día, 2 = Distribuido)")]
        [Required]
        public List<int?> ModalidadReposicion { get; set; }

        [Display(Name = "Descripción de cómo repondrá el tiempo")]
        [Required]
        public List<string> DetalleReposicion { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
