using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PP_NominasBack.Models.Catalogos.CompensacionesDeducciones
{
    public class FiniquitoLiquidacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        public DateTime FechaFiniquito { get; set; }

        public string Conceptos { get; set; }

        public decimal? IsrCalculado { get; set; }

        public decimal? TotalFiniquito { get; set; }

        public Auditable Auditoria { get; set; }
    }
}
