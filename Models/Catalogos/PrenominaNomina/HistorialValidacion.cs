using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.PrenominaNomina
{
    public class HistorialValidacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PeriodoNominaId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UsuarioValidadorId { get; set; }

        public string Resultado { get; set; }

        public DateTime? FechaValidacion { get; set; }

        public string Observaciones { get; set; }

        public string Auditable { get; set; }

    }
}