using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class PlazaDto
    {
        [Display(Name = "ID de la plaza")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Código único de la plaza")]
        [Required]
        public List<string> ClavePlaza { get; set; }

        [Display(Name = "Nombre asignado a la plaza")]
        [Required]
        public List<string> NombrePlaza { get; set; }

        [Display(Name = "Puesto de la plaza")]
        [Required]
        public List<string> PuestoId { get; set; }

        [Display(Name = "Departamento al que pertenece la plaza")]
        [Required]
        public List<string> DepartamentoId { get; set; }

        [Display(Name = "Estatus (0 = Vacante, 1 = Ocupada)")]
        [Required]
        public List<int?> EstatusPlaza { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
