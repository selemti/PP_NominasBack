using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class TablaUma
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public decimal? ValorUma { get; set; }

        public DateTime? FechaInicioVigencia { get; set; }

        public DateTime? FechaFinVigencia { get; set; }

        public int? EjercicioFiscal { get; set; }

        public string Auditable { get; set; }

    }
}