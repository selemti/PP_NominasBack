using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Seguridad
{
    public class Perfil
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombrePerfil { get; set; }

        public string DescripcionPerfil { get; set; }

        public string Auditable { get; set; }

    }
}