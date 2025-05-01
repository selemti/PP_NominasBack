using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Configuracion
{
    public class ParametroSistema
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ClaveParametro { get; set; }

        public string ValorParametro { get; set; }

        public string DescripcionParametro { get; set; }

        public string Auditable { get; set; }

    }
}