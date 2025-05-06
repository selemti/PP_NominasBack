using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.Models.Catalogos.Shared;

namespace PP_NominasBack.Dtos.Catalogos.Empleados
{
    public class AsignacionPlazaEmpleadoDto
    {
    public ObjectId Id { get; set; }

        [Display(Name = "ID de asignación")]
        [Required]
        public List<string> Id { get; set; }

        [Display(Name = "Empleado asignado")]
        [Required]
        public List<string> EmpleadoId { get; set; }

        [Display(Name = "Plaza asignada")]
        [Required]
        public List<string> PlazaId { get; set; }

        [Display(Name = "Valor del salario asignado")]
        [Required]
        public List<decimal?> Salario { get; set; }

        [Display(Name = "Tipo de salario (0 = Mensual, 1 = Diario, 2 = Hora)")]
        [Required]
        public List<int?> TipoSalario { get; set; }

        [Display(Name = "Inicio de asignación")]
        [Required]
        public List<DateTime?> FechaInicio { get; set; }

        [Display(Name = "Fin de asignación (nullable)")]
        [Required]
        public List<DateTime?> FechaFin { get; set; }

        [Display(Name = "Si la asignación está activa")]
        [Required]
        public List<bool?> Vigente { get; set; }

        [Display(Name = "Hereda campos de auditoría")]
        [Required]
        public List<Auditable?> Auditable { get; set; }

    }
}
