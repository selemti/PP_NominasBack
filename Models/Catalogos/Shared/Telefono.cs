using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class Telefono
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string TipoEntidad { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EntidadId { get; set; }

        public string ClavePais { get; set; }

        public string NumeroTelefonico { get; set; }

        public string Extension { get; set; }

        public int? TipoTelefono { get; set; }

        public string Auditable { get; set; }

    }
}