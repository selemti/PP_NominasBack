using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Shared
{
    public class CatalogoEntidadesDto
    {
        [Display(Name = "ID único de la entidad")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Código corto de la entidad (uso polimórfico)")]
        [Required]
        public List<string> EntityCode { get; set; }

        [Display(Name = "Nombre descriptivo de la entidad")]
        [Required]
        public List<string> NombreEntidad { get; set; }

        [Display(Name = "Módulo o microservicio donde se usa")]
        [Required]
        public List<string> ModuloRelacionado { get; set; }

        [Display(Name = "Descripción funcional de la entidad")]
        [Required]
        public List<string> DescripcionEntidad { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
