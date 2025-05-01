using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.ContratosPrestaciones
{
    public class TipoContrato
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string NombreContrato { get; set; }

        public string DescripcionContrato { get; set; }

        public string Auditable { get; set; }

    }
}