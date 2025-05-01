using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Shared
{
    public class CatalogoentidadesDto
    {
        /// Código corto de la entidad (uso polimórfico)
        public string EntityCode { get; set; }

        /// Nombre descriptivo de la entidad
        public string NombreEntidad { get; set; }

        /// Módulo o microservicio donde se usa
        public string ModuloRelacionado { get; set; }

        /// Descripción funcional de la entidad
        public string DescripcionEntidad { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}