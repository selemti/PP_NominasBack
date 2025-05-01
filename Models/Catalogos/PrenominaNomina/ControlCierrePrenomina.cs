using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.PrenominaNomina
{
    public class ControlCierrePrenomina
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PeriodoNominaId { get; set; }

        public DateTime? FechaCierre { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string UsuarioCierreId { get; set; }

        public string Auditable { get; set; }

    }
}