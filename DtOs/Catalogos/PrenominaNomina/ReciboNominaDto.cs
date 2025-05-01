using System;
using System.ComponentModel.DataAnnotations;

namespace PP_NominasBack.Dtos.Catalogos.PrenominaNomina
{
    public class ReciboNominaDto
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "EmpleadoId")]
        public string EmpleadoId { get; set; }

        [Required]
        [Display(Name = "PeriodoNominaId")]
        public string PeriodoNominaId { get; set; }

        [Display(Name = "TotalPercepciones")]
        public decimal? TotalPercepciones { get; set; }

        [Display(Name = "TotalDeducciones")]
        public decimal? TotalDeducciones { get; set; }

        [Display(Name = "TotalNeto")]
        public decimal? TotalNeto { get; set; }

        [Display(Name = "FormaPago")]
        public int? FormaPago { get; set; }

        [Required]
        [Display(Name = "BancoId")]
        public string BancoId { get; set; }

        [Required]
        [Display(Name = "CuentaBancaria")]
        public string CuentaBancaria { get; set; }

        [Required]
        [Display(Name = "Auditable")]
        public string Auditable { get; set; }

        [Display(Name = "TipoNomina")]
        public int? TipoNomina { get; set; }

        [Display(Name = "NetoGravado")]
        public decimal? NetoGravado { get; set; }

        [Display(Name = "NetoExento")]
        public decimal? NetoExento { get; set; }

        [Display(Name = "NetoExcedente")]
        public decimal? NetoExcedente { get; set; }

    }
}