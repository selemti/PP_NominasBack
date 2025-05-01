using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Vacaciones
{
    public class PermisosDto
    {
        /// Empleado que solicita permiso
        public string? EmpleadoId { get; set; }

        /// Tipo de permiso (0 = Con goce, 1 = Sin goce, 2 = Otro)
        [Required]
        public TipoPermisoEnum TipoPermiso { get; set; }

        /// Fecha inicial del permiso
        [Required]
        public DateTime FechaInicio { get; set; }

        /// Fecha final del permiso
        [Required]
        public DateTime FechaFin { get; set; }

        /// ¿Se requiere suplente?
        [Required]
        public bool RequiereSuplente { get; set; }

        /// Tipo de reposición (0 = No repone, 1 = Mismo día, 2 = Distribuido)
        [Required]
        public ModalidadReposicionEnum ModalidadReposicion { get; set; }

        /// Descripción de cómo repondrá el tiempo
        public string DetalleReposicion { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}