using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.AlertasValidacionesEnums
{
    public class CatalogoEnums
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string EnumCode { get; set; }

        public int? EnumKey { get; set; }

        public string Valor { get; set; }

        public string Descripcion { get; set; }

        public bool? Activo { get; set; }

        public string Auditable { get; set; }

    }
}