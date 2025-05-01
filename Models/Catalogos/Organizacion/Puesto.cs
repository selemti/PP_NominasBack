using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Puesto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ClavePuesto { get; set; }

        public string NombrePuesto { get; set; }

        public string DescripcionPuesto { get; set; }

        public string Auditable { get; set; }

    }
}