using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.AlertasValidacionesEnums
{
    public class CatalogoEntidades
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string EntityCode { get; set; }

        public string NombreEntidad { get; set; }

        public string ModuloRelacionado { get; set; }

        public string DescripcionEntidad { get; set; }

        public string Auditable { get; set; }

    }
}