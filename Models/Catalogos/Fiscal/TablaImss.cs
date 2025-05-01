using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class TablaImss
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Concepto { get; set; }

        public decimal? PorcentajePatronal { get; set; }

        public decimal? PorcentajeObrero { get; set; }

        public bool? SalarioMinimoAplica { get; set; }

        public int? EjercicioFiscal { get; set; }

        public string Auditable { get; set; }

    }
}