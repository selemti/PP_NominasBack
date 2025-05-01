using System;
using System.ComponentModel.DataAnnotations;
using PP_NominasBack.DTOs.Catalogos.Shared;

namespace PP_NominasBack.DTOs.Catalogos.Nómina
{
    public class CentropagonominaDto
    {
        /// Nombre del centro de pago
        public string NombreCentroPago { get; set; }

        /// Fecha de corte quincena 1
        public string FechaCorteQuincena1 { get; set; }

        /// Fecha de corte quincena 2
        public string FechaCorteQuincena2 { get; set; }

        /// Día de pago 1
        public string FechaPagoQuincena1 { get; set; }

        /// Día de pago 2
        public string FechaPagoQuincena2 { get; set; }

        /// Hereda campos de auditoría
        public string? Auditable { get; set; }

    }
}