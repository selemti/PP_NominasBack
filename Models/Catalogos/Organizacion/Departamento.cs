using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Departamento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ClaveDepartamento { get; set; }

        public string NombreDepartamento { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string DivisionId { get; set; }

        public string Auditable { get; set; }

    }
}