
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.Nomina
{
    public class ReciboNominaDto
    {
        [Display(Name = "ID de Recibo de Nómina")]
        [Required]
        public string Id { get; set; }

        [Display(Name = "EmpleadoId")]
        [Required]
        public string EmpleadoId { get; set; } // Relación con el Empleado

        [Display(Name = "Periodo de Nómina")]
        [Required]
        public string PeriodoNominaId { get; set; } // Periodo de Nómina

        [Display(Name = "Horas Extras Trabajadas")]
        [Required]
        public double HorasExtrasTrabajadas { get; set; } // Horas extras trabajadas

        [Display(Name = "Horas Extras Autorizadas")]
        [Required]
        public double HorasExtrasAutorizadas { get; set; } // Horas extras autorizadas

        [Display(Name = "Total de Percepciones")]
        public decimal TotalPercepciones { get; set; } // Total de percepciones calculadas

        [Display(Name = "Total de Deducciones")]
        public decimal TotalDeducciones { get; set; } // Total de deducciones aplicadas

        [Display(Name = "Total Neto")]
        public decimal TotalNeto { get; set; } // Total neto a pagar

        [Display(Name = "Auditable")]
        [Required]
        public Auditable Auditable { get; set; } // Información de auditoría
    }
}
