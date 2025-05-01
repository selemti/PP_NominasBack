using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Incidencias
{
    public class Justificante
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int? TipoJustificante { get; set; }

        public string UrlDocumento { get; set; }

        public DateTime? FechaEmision { get; set; }

        public string Auditable { get; set; }

    }
}