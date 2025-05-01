using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.CompensacionesDeducciones
{
    public class EmpleadoDeduccion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string DeduccionId { get; set; }

        public decimal? Valor { get; set; }

        public int? Periodicidad { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public string Auditable { get; set; }

    }
}