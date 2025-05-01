using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Plaza
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ClavePlaza { get; set; }

        public string NombrePlaza { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PuestoId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string DepartamentoId { get; set; }

        public int? EstatusPlaza { get; set; }

        public string Auditable { get; set; }

    }
}