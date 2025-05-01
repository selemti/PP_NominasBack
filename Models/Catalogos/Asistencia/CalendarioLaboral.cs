using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Asistencia
{
    public class CalendarioLaboral
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public DateTime? Fecha { get; set; }

        public int? TipoDia { get; set; }

        public string DescripcionEvento { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EmpresaId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string DivisionId { get; set; }

        public bool? Vigente { get; set; }

        public string Auditable { get; set; }

    }
}