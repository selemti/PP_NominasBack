using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace PP_NominasBack.Models.Catalogos.PrenominaNomina
{
    public class PeriodoNomina
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string TipoPeriodoId { get; set; }

        public string Auditable { get; set; }

        public int? TipoNomina { get; set; }

    }
}