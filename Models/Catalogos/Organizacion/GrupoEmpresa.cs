using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class GrupoEmpresa
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Clave { get; set; }

        public string Nombre { get; set; }

        public string Rfc { get; set; }

        public string Auditable { get; set; }

    }
}