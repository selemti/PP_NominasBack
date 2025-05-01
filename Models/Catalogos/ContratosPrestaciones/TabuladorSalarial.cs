using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.ContratosPrestaciones
{
    public class TabuladorSalarial
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string PuestoId { get; set; }

        public decimal? SalarioMinimo { get; set; }

        public decimal? SalarioMaximo { get; set; }

        public string Auditable { get; set; }

    }
}