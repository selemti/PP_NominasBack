using System;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class Auditable
    {
        public string CreadoPor { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}