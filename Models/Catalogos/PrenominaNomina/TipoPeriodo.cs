using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.PrenominaNomina
{
    public class TipoPeriodo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombreTipoPeriodo { get; set; }

        public int? DiasPeriodo { get; set; }

        public string Auditable { get; set; }

    }
}