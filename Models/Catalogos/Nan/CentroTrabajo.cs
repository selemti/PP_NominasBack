using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Nan
{
    public class CentroTrabajo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombreCentroTrabajo { get; set; }

        public string ClaveCentroTrabajo { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string DireccionId { get; set; }

        public string RegistroPatronal { get; set; }

        public string Auditable { get; set; }

    }
}