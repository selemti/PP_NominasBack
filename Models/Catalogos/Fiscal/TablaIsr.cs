using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.Fiscal
{
    public class TablaIsr
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public decimal? LimiteInferior { get; set; }

        public decimal? LimiteSuperior { get; set; }

        public decimal? CuotaFija { get; set; }

        public decimal? PorcentajeExcedente { get; set; }

        public int? Periodo { get; set; }

        public int? EjercicioFiscal { get; set; }

        public string Auditable { get; set; }

    }
}