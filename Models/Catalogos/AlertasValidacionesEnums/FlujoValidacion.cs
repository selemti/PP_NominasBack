using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.AlertasValidacionesEnums
{
    public class FlujoValidacion
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombreFlujo { get; set; }

        public string ProcesoRelacionado { get; set; }

        public string DescripcionFlujo { get; set; }

        public bool? Activo { get; set; }

        public string Auditable { get; set; }

    }
}