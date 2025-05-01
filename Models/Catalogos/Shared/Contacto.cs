using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Shared
{
    public class Contacto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string TipoEntidad { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string EntidadId { get; set; }

        public string NombreContacto { get; set; }

        public string TelefonoContacto { get; set; }

        public string Parentesco { get; set; }

        public string Auditable { get; set; }

    }
}