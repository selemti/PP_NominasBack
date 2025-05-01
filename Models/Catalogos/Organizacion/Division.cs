using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Division
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string GrupoEmpresaId { get; set; }

        public string ClaveDivision { get; set; }

        public string NombreDivision { get; set; }

        public string Auditable { get; set; }

    }
}