using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Organizacion
{
    public class OrganigramaDto
    {
        [Display(Name = "ID único del nodo")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "División o UDN relacionada")]
        [Required]
        public List<string> DivisionId { get; set; }

        [Display(Name = "Puesto del nodo")]
        [Required]
        public List<string> PuestoId { get; set; }

        [Display(Name = "Centro de costo asignado")]
        [Required]
        public List<string> CentroCostoId { get; set; }

        [Display(Name = "Padre del nodo en estructura")]
        [Required]
        public List<string> NodoPadreId { get; set; }

        [Display(Name = "Nivel jerárquico")]
        [Required]
        public List<int?> Nivel { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
