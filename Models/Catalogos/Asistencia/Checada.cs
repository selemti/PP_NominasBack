using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class Checada
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpleadoId { get; set; }

        public DateTime? FechaHora { get; set; }

        public int? TipoEvento { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string DispositivoId { get; set; }

        public string Auditable { get; set; }

    }
}