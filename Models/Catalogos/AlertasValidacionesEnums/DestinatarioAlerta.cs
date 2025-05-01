using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.AlertasValidacionesEnums
{
    public class DestinatarioAlerta
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string AlertaId { get; set; }

        public int? TipoDestinatario { get; set; }

        public string ValorDestino { get; set; }

        public string Auditable { get; set; }

    }
}