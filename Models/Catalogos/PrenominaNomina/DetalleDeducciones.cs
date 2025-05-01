using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.PrenominaNomina
{
    public class DetalleDeducciones
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ReciboNominaId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string TipoDeduccionId { get; set; }

        public decimal? Monto { get; set; }

        public string Auditable { get; set; }

    }
}