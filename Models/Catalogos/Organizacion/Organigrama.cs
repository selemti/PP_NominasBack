using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Organizacion
{
    public class Organigrama
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string DivisionId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PuestoId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CentroCostoId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string NodoPadreId { get; set; }

        public int? Nivel { get; set; }

        public string Auditable { get; set; }

    }
}