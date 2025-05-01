using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.FondosAhorro
{
    public class FondoAhorro
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        public decimal? SaldoActual { get; set; }

        public decimal? PorcentajeAportacion { get; set; }

        public bool? Vigente { get; set; }

        public string Auditable { get; set; }

    }
}