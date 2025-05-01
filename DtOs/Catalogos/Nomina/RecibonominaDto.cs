using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Nómina
{
    public class RecibonominaDto
    {
        /// Empleado asociado al recibo
        public string? EmpleadoId { get; set; }

        /// Periodo de nómina del recibo
        public string? PeriodoNominaId { get; set; }

        /// Total de percepciones brutas
        public string TotalPercepciones { get; set; }

        /// Total de deducciones
        public string TotalDeducciones { get; set; }

        /// Neto a pagar
        public string TotalNeto { get; set; }

        /// Forma de pago (0 = Transferencia, 1 = Cheque)
        [Required]
        public FormaPagoEnum FormaPago { get; set; }

        /// Banco donde se dispersa el pago
        public string? BancoId { get; set; }

        /// Cuenta de dispersión
        public string CuentaBancaria { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

        /// Tipo de nómina (0 = Administrativo, 1 = Crew, 2 = Overhead)
        [Required]
        public TipoNominaEnum TipoNomina { get; set; }

        /// Monto total gravado
        public string NetoGravado { get; set; }

        /// Monto total exento
        public string NetoExento { get; set; }

        /// Monto de excedente no fiscalizado
        public string NetoExcedente { get; set; }

    }
}