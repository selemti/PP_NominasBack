using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.PrenominaNomina
{
    public class CfdiNomina
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ReciboNominaId { get; set; }

        public string Uuid { get; set; }

        public string SelloDigital { get; set; }

        public DateTime? FechaTimbre { get; set; }

        public string Auditable { get; set; }

    }
}