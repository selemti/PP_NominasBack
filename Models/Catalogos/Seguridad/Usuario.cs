using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Seguridad
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombreUsuario { get; set; }

        public string CorreoElectronico { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PerfilId { get; set; }

        public int? EstatusUsuario { get; set; }

        public string Auditable { get; set; }

    }
}